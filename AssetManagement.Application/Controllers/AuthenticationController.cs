using AssetManagement.Contracts;
using AssetManagement.Contracts.Authentication;
using AssetManagement.Contracts.Constant;
using AssetManagement.Domain.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AssetManagement.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<User> userManager;
        private readonly IConfiguration configuration;
        public AuthenticationController(UserManager<User> userManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.configuration = configuration;
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDTO loginModel)
        {
            var user = await userManager.FindByNameAsync(loginModel.Username);
            if (user != null && await userManager.CheckPasswordAsync(user, loginModel.Password))
            {
                if (user.IsDisabled)
                {
                    return BadRequest(ErrorCode.USER_ALREADY_DISABLED);
                }
                var token = await GetToken(user);

                var refreshToken = await userManager.GenerateUserTokenAsync(user, TokenConstant.TokenProvider, TokenConstant.RefreshToken);

                var userRole = await userManager.GetRolesAsync(user);

                await userManager.SetAuthenticationTokenAsync(user, TokenConstant.TokenProvider, TokenConstant.RefreshToken, refreshToken);

                return Ok(new JwtResponse { Token = new JwtSecurityTokenHandler().WriteToken(token), Expiration = token.ValidTo, Username = user.UserName, RefreshToken = refreshToken, Role = userRole.First(), IsPasswordChanged = user.IsPasswordChanged });
            }
            return Unauthorized(ErrorCode.USERNAME_OR_PASSWORD_NOT_CORRECT);

        }

        [HttpPost("refreshToken")]
        public async Task<IActionResult> RefreshToken(string accessToken, string refreshToken)
        {
            if (refreshToken is null)
                return BadRequest(ErrorCode.REFRESH_TOKEN_INVALID);

            var principal = GetPrincipalFromExpiredToken(accessToken);

            if (principal == null)
                return BadRequest(ErrorCode.TOKEN_INVALID);

            var user = await userManager.FindByNameAsync(principal.Identity.Name);

            var isValid = await userManager.VerifyUserTokenAsync(user, TokenConstant.TokenProvider, TokenConstant.RefreshToken, refreshToken);

            if (isValid)
            {
                await userManager.RemoveAuthenticationTokenAsync(user, TokenConstant.TokenProvider, TokenConstant.RefreshToken);

                var token = await GetToken(user);

                var userRole = await userManager.GetRolesAsync(user);

                var newRefreshToken = await userManager.GenerateUserTokenAsync(user, TokenConstant.TokenProvider, TokenConstant.RefreshToken);

                await userManager.SetAuthenticationTokenAsync(user, TokenConstant.TokenProvider, TokenConstant.RefreshToken, newRefreshToken);

                return Ok(new JwtResponse { Token = new JwtSecurityTokenHandler().WriteToken(token), Expiration = token.ValidTo, Username = user.UserName, RefreshToken = refreshToken, Role = userRole.First(), IsPasswordChanged = user.IsPasswordChanged });
            }

            return BadRequest(ErrorCode.REFRESH_TOKEN_NOT_VALID);
        }

        [Authorize]
        [HttpPut("changePassword")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDTO changePassword)
        {
            var username = HttpContext.User.Claims.Single(x => x.Type == ClaimTypes.Name).Value;

            var user = await userManager.FindByNameAsync(username);

            if (user is not null)
            {
                var checkPassword = await userManager.CheckPasswordAsync(user, changePassword.OldPassword);

                if (!checkPassword)
                    return BadRequest(ErrorCode.PASSWORD_IS_NOT_CORRECT);

                var result = await userManager.ChangePasswordAsync(user, changePassword.OldPassword, changePassword.NewPassword);

                if (!result.Succeeded)
                    return BadRequest(ErrorCode.CHANGE_PASSWORD_FAILED);

                if (!user.IsPasswordChanged)
                    user.IsPasswordChanged = true;

                await userManager.UpdateAsync(user);

                return Ok(SuccessCode.CHANGE_PASSWORD_SUCCESSFULLY);
            }
            return BadRequest(ErrorCode.USER_NOT_VALID);
        }

        private async Task<JwtSecurityToken> GetToken(User user)
        {
            var userRoles = await userManager.GetRolesAsync(user);

            var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim( JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };

            foreach (var userRole in userRoles)
            {
                authClaims.Add(new Claim(ClaimTypes.Role, userRole));
            }

            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: configuration["JWT:ValidIssuer"],
                audience: configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddMinutes(30),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

            return token;
        }

        private ClaimsPrincipal? GetPrincipalFromExpiredToken(string? token)
        {
            if(token is not null)
            {
                var tokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = true,
                    ValidateIssuer = true,
                    ValidAudience = configuration["JWT:ValidAudience"],
                    ValidIssuer = configuration["JWT:ValidIssuer"],
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"])),
                    ValidateLifetime = false
                };

                var tokenHandler = new JwtSecurityTokenHandler();

                var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);

                if (securityToken is not JwtSecurityToken jwtSecurityToken || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
                    throw new SecurityTokenException("Invalid token");

                return principal;
            }
            return null;
        }
    }
}
