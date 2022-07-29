using AssetManagement.Contracts.Constant;
using AssetManagement.Contracts.UserDTO;
using AssetManagement.Data.Repository.Interface;
using AssetManagement.Domain.Model;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AssetManagement.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<User> userManager;
        private readonly IRoleRepository roleRepository;
        private readonly IMapper mapper;
        public UserController(UserManager<User> userManager, IMapper mapper, IRoleRepository roleRepository)
        {
            this.userManager = userManager;
            this.mapper = mapper;
            this.roleRepository = roleRepository;
        }
        [HttpPost("createUser")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserDTO userDTO)
        {
            var currentDate = DateTime.Now;

            var dob = userDTO.DateOfBirth;

            var joinedDate = userDTO.JoinedDate;

            if (currentDate.Year - dob.Year < 18)
                return BadRequest(ErrorCode.USER_UNDER_18);

            if (joinedDate.DayOfWeek == DayOfWeek.Saturday || joinedDate.DayOfWeek == DayOfWeek.Sunday)
                return BadRequest(ErrorCode.JOINED_DATE_IS_SATURDAY_OR_SUNDAY);

            var user = mapper.Map<User>(userDTO);

            user.UserName = await GenerateUsername(userDTO.FirstName, userDTO.LastName);

            var password = $"{user.UserName}@{user.DateOfBirth:ddMMyyyy}";

            var adminUsername = HttpContext.User.Claims.Single(x => x.Type == ClaimTypes.Name).Value;

            var admin = await userManager.FindByNameAsync(adminUsername);

            user.LocationId = admin.LocationId;

            var role = await roleRepository.GetRoleByIdAsync(userDTO.Type);

            if (role is null)
                return NotFound(ErrorCode.ROLE_NOT_FOUND);

            var result = await userManager.CreateAsync(user, password);

            if (!result.Succeeded)
                return BadRequest(ErrorCode.CREATE_USER_FAILED);

            var roleResult = await userManager.AddToRoleAsync(user, role.Name);

            user.StaffCode = $"SD{user.Id.ToString().PadLeft(4, '0')}";

            await userManager.UpdateAsync(user);

            if(!roleResult.Succeeded)
                return BadRequest(ErrorCode.ADD_USER_TO_ROLE_FAILED);

            return Ok(SuccessCode.CREATE_USER_SUCCESSFULLY);
        }
        private async Task<string> GenerateUsername(string firstName, string lastName)
        {
            string[] lastNameSplit = lastName.Split();

            string username = String.Concat(firstName.ToLower().Where(c => !Char.IsWhiteSpace(c)));

            foreach (var word in lastNameSplit)
            {
                username += word.Substring(0, 1).ToLower();
            }

            var checkExistUsername = await userManager.FindByNameAsync(username);
            if (checkExistUsername != null)
            {
                var i = 0;
                var alterUsername = username;
                while (await userManager.FindByNameAsync(alterUsername) != null)
                {
                    i++;
                    alterUsername = $"{username}{i}";
                }
                return alterUsername;
            }
            return username;
        }
    }
}
