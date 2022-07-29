using AssetManagement.Application.Controllers;
using AssetManagement.Contracts;
using AssetManagement.Contracts.Authentication;
using AssetManagement.Contracts.Constant;
using AssetManagement.Domain.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Moq;
using System.Security.Claims;
using System.Security.Principal;

namespace AssetManagement.Application.Tests
{
    public class AuthenticationControllerTests
    {
        private string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiQWRtaW4iLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6IjEiLCJqdGkiOiJiZjQ0ODFkYy1iY2ZkLTRlZDEtYjkzNC02ZTM4M2YwM2E4ZmQiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJBZG1pbiIsImV4cCI6MTY1ODQ1NDY3MywiaXNzIjoiaHR0cDovL2xvY2FsaG9zdDo1MDAwIiwiYXVkIjoiaHR0cDovL2xvY2FsaG9zdDo0MjAwIn0.vUeWrVQL0gAIQlNnIhsowp42-AwBEiqv2aH0NNaWYt4";
        private string refreshToken = "CfDJ8K4QAUEnk3dMoMoLfmWyvqQ7GTqJ0EHws+9cy6eyCXUZd70s/BWL65awaVNRsxNo80U9/BbtsmgUArW8N/NTpmLS4TdQSK55kFvwyI9uvVHFIX4+Zuy87AqSVhFzNCe9gkVpq5xc9dfQ1nuEH6d8NQWxpzP+zg1MSr5E0/n328ax+O1VWr1qImn0oquKm0acqg==";
        [Fact]
        public async Task Test_Authentication_Login_Return_ResponseJWT()
        {
            var mockUserManager = new Mock<FakeUserManager>();
            var config = new Mock<IConfiguration>();

            mockUserManager.Setup(u => u.FindByNameAsync(It.IsAny<string>())).Returns(Task.FromResult(GetUser()));

            mockUserManager.Setup(u => u.CheckPasswordAsync(It.IsAny<User>(), It.IsAny<string>())).Returns(Task.FromResult(true));

            mockUserManager.Setup(u => u.GetRolesAsync(It.IsAny<User>())).Returns(Task.FromResult(GetUserRole()));

            config.Setup(c => c["JWT:Secret"]).Returns(Guid.NewGuid().ToString());

            config.Setup(c => c["JWT:ValidIssuer"]).Returns("ABC");

            config.Setup(c => c["JWT:ValidAudience"]).Returns("XYZ");

            var refreshToken = "85dadaae-07b2-49d0-a77a-e2c5aeece1d3";

            mockUserManager.Setup(u => u.GenerateUserTokenAsync(It.IsAny<User>(), It.IsAny<string>(), It.IsAny<string>())).Returns(Task.FromResult(refreshToken));

            mockUserManager.Setup(u => u.SetAuthenticationTokenAsync(It.IsAny<User>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(Task.FromResult(new IdentityResult()));

            AuthenticationController controller = new(mockUserManager.Object, config.Object);

            var result = await controller.Login(new LoginDTO { Username = "Admin", Password = "Admin123" });

            var okResult = result as OkObjectResult;

            Assert.IsType<OkObjectResult>(okResult);

            Assert.IsType<JwtResponse>(okResult.Value);

        }

        [Fact]
        public async Task Test_Authentication_Login_User_Is_Disabled()
        {
            var mockUserManager = new Mock<FakeUserManager>();

            var config = new Mock<IConfiguration>();

            var disabledUser = GetUser();
            disabledUser.IsDisabled = true;

            mockUserManager.Setup(u => u.FindByNameAsync(It.IsAny<string>())).Returns(Task.FromResult(disabledUser));

            mockUserManager.Setup(u => u.CheckPasswordAsync(It.IsAny<User>(), It.IsAny<string>())).Returns(Task.FromResult(true));

            AuthenticationController controller = new(mockUserManager.Object, config.Object);

            var result = await controller.Login(new LoginDTO { Username = "Admin", Password = "Admin123" });

            var badResult = result as BadRequestObjectResult;

            Assert.IsType<BadRequestObjectResult>(badResult);

            Assert.Equal(ErrorCode.USER_ALREADY_DISABLED, badResult.Value);

        }

        [Fact]
        public async Task Test_Authentication_Login_Username_And_Password_Not_Correct()
        {
            var mockUserManager = new Mock<FakeUserManager>();

            var config = new Mock<IConfiguration>();

            mockUserManager.Setup(u => u.FindByNameAsync(It.IsAny<string>())).Returns(Task.FromResult(GetUser()));

            mockUserManager.Setup(u => u.CheckPasswordAsync(It.IsAny<User>(), It.IsAny<string>())).Returns(Task.FromResult(false));

            AuthenticationController controller = new(mockUserManager.Object, config.Object);

            var result = (await controller.Login(new LoginDTO { Username = "Admin", Password = "Admin345" })) as UnauthorizedObjectResult;

            Assert.IsType<UnauthorizedObjectResult>(result);

            Assert.Equal(ErrorCode.USERNAME_OR_PASSWORD_NOT_CORRECT, result.Value);
        }
        [Fact]
        public async Task Test_Authentication_RefreshToken_Return_ResponseJWT()
        {
            var mockUserManager = new Mock<FakeUserManager>();
            var config = new Mock<IConfiguration>();

            config.Setup(c => c["JWT:Secret"]).Returns("JWTAuthenticationHIGHsecuredPasswordVVVp1OH7Xzyr");

            config.Setup(c => c["JWT:ValidIssuer"]).Returns("http://localhost:5000");

            config.Setup(c => c["JWT:ValidAudience"]).Returns("http://localhost:4200");

            mockUserManager.Setup(u => u.FindByNameAsync(It.IsAny<string>())).Returns(Task.FromResult(GetUser()));

            mockUserManager.Setup(u => u.VerifyUserTokenAsync(It.IsAny<User>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(Task.FromResult(true));

            mockUserManager.Setup(u => u.RemoveAuthenticationTokenAsync(It.IsAny<User>(), It.IsAny<string>(), It.IsAny<string>())).Returns(Task.FromResult(new IdentityResult()));

            mockUserManager.Setup(u => u.GetRolesAsync(It.IsAny<User>())).Returns(Task.FromResult(GetUserRole()));

            var newRefreshToken = "85dadaae-07b2-49d0-a77a-e2c5aeece1d3";

            mockUserManager.Setup(u => u.GenerateUserTokenAsync(It.IsAny<User>(), It.IsAny<string>(), It.IsAny<string>())).Returns(Task.FromResult(newRefreshToken));

            mockUserManager.Setup(u => u.SetAuthenticationTokenAsync(It.IsAny<User>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(Task.FromResult(new IdentityResult()));

            AuthenticationController controller = new(mockUserManager.Object, config.Object);

            var result = await controller.RefreshToken(token, refreshToken) as OkObjectResult;

            Assert.IsType<OkObjectResult>(result);

            Assert.IsType<JwtResponse>(result.Value);
        }

        [Fact]
        public async Task Test_Authentication_RefreshToken_With_Refresh_Token_Null_Return_BadRequest()
        {
            var mockUserManager = new Mock<FakeUserManager>();
            var config = new Mock<IConfiguration>();

            AuthenticationController controller = new(mockUserManager.Object, config.Object);

            var result = await controller.RefreshToken(token, null) as BadRequestObjectResult;

            Assert.IsType<BadRequestObjectResult>(result);

            Assert.Equal(ErrorCode.REFRESH_TOKEN_INVALID, result.Value);
        }

        [Fact]
        public async Task Test_Authentication_RefreshToken_With_Token_Null_Return_BadRequest()
        {
            var mockUserManager = new Mock<FakeUserManager>();
            var config = new Mock<IConfiguration>();

            AuthenticationController controller = new(mockUserManager.Object, config.Object);

            var result = await controller.RefreshToken(null, refreshToken) as BadRequestObjectResult;

            Assert.IsType<BadRequestObjectResult>(result);

            Assert.Equal(ErrorCode.TOKEN_INVALID, result.Value);
        }

        [Fact]
        public async Task Test_Authentication_RefreshToken_With_Verify_Refresh_Token_Failed_Return_BadRequest()
        {
            var mockUserManager = new Mock<FakeUserManager>();
            var config = new Mock<IConfiguration>();

            config.Setup(c => c["JWT:Secret"]).Returns("JWTAuthenticationHIGHsecuredPasswordVVVp1OH7Xzyr");

            config.Setup(c => c["JWT:ValidIssuer"]).Returns("http://localhost:5000");

            config.Setup(c => c["JWT:ValidAudience"]).Returns("http://localhost:4200");

            mockUserManager.Setup(u => u.FindByNameAsync(It.IsAny<string>())).Returns(Task.FromResult(GetUser()));

            mockUserManager.Setup(u => u.VerifyUserTokenAsync(It.IsAny<User>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(Task.FromResult(false));

            AuthenticationController controller = new(mockUserManager.Object, config.Object);

            var result = await controller.RefreshToken(token, refreshToken) as BadRequestObjectResult;

            Assert.IsType<BadRequestObjectResult>(result);

            Assert.Equal(ErrorCode.REFRESH_TOKEN_NOT_VALID, result.Value);
        }
        [Fact]
        public async Task Test_Authentication_ChangePassword_Return_OkResult_With_SuccessCode()
        {
            var mockUserManager = new Mock<FakeUserManager>();
            var config = new Mock<IConfiguration>();

            var identity = new GenericIdentity(ClaimTypes.Name, "Admin");
            var contextUser = new ClaimsPrincipal(identity);

            var httpContext = new DefaultHttpContext()
            {
                User = contextUser
            };

            var controllerContext = new ControllerContext()
            {
                HttpContext = httpContext,
            };

            mockUserManager.Setup(u => u.FindByNameAsync(It.IsAny<string>())).Returns(Task.FromResult(GetUser()));

            mockUserManager.Setup(u => u.CheckPasswordAsync(It.IsAny<User>(), It.IsAny<string>())).Returns(Task.FromResult(true));

            mockUserManager.Setup(u => u.ChangePasswordAsync(It.IsAny<User>(), It.IsAny<string>(), It.IsAny<string>())).Returns(Task.FromResult(IdentityResult.Success));

            AuthenticationController controller = new(mockUserManager.Object, config.Object) { ControllerContext = controllerContext };

            var result = await controller.ChangePassword(new ChangePasswordDTO { OldPassword = "Admin123", NewPassword = "Admin345" }) as OkObjectResult;

            Assert.IsType<OkObjectResult>(result);

            Assert.Equal(SuccessCode.CHANGE_PASSWORD_SUCCESSFULLY, result.Value);

        }

        [Fact]
        public async Task Test_Authentication_ChangePassword_With_Username_Not_Found_Return_BadRequest()
        {
            var mockUserManager = new Mock<FakeUserManager>();
            var config = new Mock<IConfiguration>();

            var identity = new GenericIdentity(ClaimTypes.Name,"Abc");
            var contextUser = new ClaimsPrincipal(identity);

            var httpContext = new DefaultHttpContext()
            {
                User = contextUser
            };
            
            var controllerContext = new ControllerContext()
            {
                HttpContext = httpContext,
            };

            AuthenticationController controller = new(mockUserManager.Object, config.Object) { ControllerContext = controllerContext };

            var result = await controller.ChangePassword(new ChangePasswordDTO { OldPassword = "Admin123", NewPassword = "Admin345" }) as BadRequestObjectResult;

            Assert.IsType<BadRequestObjectResult>(result);

            Assert.Equal(ErrorCode.USER_NOT_VALID, result.Value);

        }

        [Fact]
        public async Task Test_Authentication_ChangePassword_With_Password_Not_Correct_Return_BadRequest()
        {
            var mockUserManager = new Mock<FakeUserManager>();
            var config = new Mock<IConfiguration>();

            var identity = new GenericIdentity(ClaimTypes.Name, "Admin");
            var contextUser = new ClaimsPrincipal(identity);

            var httpContext = new DefaultHttpContext()
            {
                User = contextUser
            };

            var controllerContext = new ControllerContext()
            {
                HttpContext = httpContext,
            };

            mockUserManager.Setup(u => u.FindByNameAsync(It.IsAny<string>())).Returns(Task.FromResult(GetUser()));

            mockUserManager.Setup(u => u.CheckPasswordAsync(It.IsAny<User>(), It.IsAny<string>())).Returns(Task.FromResult(false));

            AuthenticationController controller = new(mockUserManager.Object, config.Object) { ControllerContext = controllerContext };

            var result = await controller.ChangePassword(new ChangePasswordDTO { OldPassword = "Admin223", NewPassword = "Admin345" }) as BadRequestObjectResult;

            Assert.IsType<BadRequestObjectResult>(result);

            Assert.Equal(ErrorCode.PASSWORD_IS_NOT_CORRECT, result.Value);
        }

        [Fact]
        public async Task Test_Authentication_ChangePassword_With_Change_Password_Not_Succeeded_Return_BadRequest()
        {
            var mockUserManager = new Mock<FakeUserManager>();
            var config = new Mock<IConfiguration>();

            var identity = new GenericIdentity(ClaimTypes.Name, "Admin");
            var contextUser = new ClaimsPrincipal(identity);

            var httpContext = new DefaultHttpContext()
            {
                User = contextUser
            };

            var controllerContext = new ControllerContext()
            {
                HttpContext = httpContext,
            };

            mockUserManager.Setup(u => u.FindByNameAsync(It.IsAny<string>())).Returns(Task.FromResult(GetUser()));

            mockUserManager.Setup(u => u.CheckPasswordAsync(It.IsAny<User>(), It.IsAny<string>())).Returns(Task.FromResult(true));

            mockUserManager.Setup(u => u.ChangePasswordAsync(It.IsAny<User>(), It.IsAny<string>(), It.IsAny<string>())).Returns(Task.FromResult(IdentityResult.Failed()));

            AuthenticationController controller = new(mockUserManager.Object, config.Object) { ControllerContext = controllerContext };

            var result = await controller.ChangePassword(new ChangePasswordDTO { OldPassword = "Admin223", NewPassword = "Admin345" }) as BadRequestObjectResult;

            Assert.IsType<BadRequestObjectResult>(result);

            Assert.Equal(ErrorCode.CHANGE_PASSWORD_FAILED, result.Value);
        }

        private User GetUser()
        {
            return new User
            {
                Id = 0,
                UserName = "Admin",
                NormalizedUserName = RoleConstant.Admin,
                IsDisabled = false
            };
        }
        private IList<string> GetUserRole()
        {
            var result = new List<string>();
            result.Add(RoleConstant.Admin);
            return result;
        }
    }
}
