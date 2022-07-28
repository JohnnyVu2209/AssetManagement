using AssetManagement.Application.Controllers;
using AssetManagement.Contracts.Constant;
using AssetManagement.Contracts.UserDTO;
using AssetManagement.Data.Repository.Interface;
using AssetManagement.Domain.Model;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Security.Claims;
using System.Security.Principal;

namespace AssetManagement.Application.Tests
{
    public class UserControllerTests
    {
        [Fact]
        public async Task Test_User_CreateUser_Return_SuccessCode()
        {
            var mockUserManager = new Mock<FakeUserManager>();
            var mockRoleRepository = new Mock<IRoleRepository>();
            var mockMapper = new Mock<IMapper>();

            var userDto = new CreateUserDTO()
            {
                FirstName = "A",
                LastName = "Nguyen Van",
                DateOfBirth = new DateTime(2000, 1, 1),
                Gender = 0,
                JoinedDate = new DateTime(2022, 10, 25),
                Type = 1
            };

            var user = new User()
            {
                Id = 1,
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                DateOfBirth = userDto.DateOfBirth,
                Gender = userDto.Gender == 1,
                JoinedDate = userDto.JoinedDate
            };

            var admin = new User()
            {
                LocationId = 1,
                UserName = "Admin"
            };

            var role = new Role()
            {
                Id = 1,
                Name = "Admin",
            };

            mockMapper.Setup(m => m.Map<User>(It.IsAny<CreateUserDTO>())).Returns(user);

            mockUserManager.Setup(u => u.FindByNameAsync(It.IsAny<string>())).Returns(Task.FromResult<User>(null));

            mockUserManager.Setup(u => u.FindByNameAsync("Admin")).Returns(Task.FromResult(admin));

            mockRoleRepository.Setup(r => r.GetRoleByIdAsync(It.IsAny<int>())).Returns(Task.FromResult(role));

            mockUserManager.Setup(u => u.CreateAsync(It.IsAny<User>(), It.IsAny<string>())).Returns(Task.FromResult(IdentityResult.Success));

            mockUserManager.Setup(u => u.AddToRoleAsync(It.IsAny<User>(), It.IsAny<string>())).Returns(Task.FromResult(IdentityResult.Success));

            mockUserManager.Setup(u => u.UpdateAsync(It.IsAny<User>())).Returns(Task.FromResult(IdentityResult.Success));

            var claimUser = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Name, "Admin"),
                new Claim(ClaimTypes.NameIdentifier, "1"),
            }, "mock"));

            var identity = new GenericIdentity(ClaimTypes.Name, "AdminHCM");

            identity.AddClaim(new Claim(ClaimTypes.Role, "Admin"));

            var contextUser = new ClaimsPrincipal(identity);

            var httpContext = new DefaultHttpContext()
            {
                User = claimUser,
            };

            var controllerContext = new ControllerContext()
            {
                HttpContext = httpContext,
            };

            UserController controller = new(mockUserManager.Object, mockMapper.Object, mockRoleRepository.Object) { ControllerContext = controllerContext };

            var result = await controller.CreateUser(userDto) as OkObjectResult;

            Assert.IsType<OkObjectResult>(result);

            Assert.Equal(SuccessCode.CREATE_USER_SUCCESSFULLY, result.Value);
        }

        [Fact]
        public async Task Test_User_CreateUser_With_Username_Already_Exists_Return_SuccessCode()
        {
            var mockUserManager = new Mock<FakeUserManager>();
            var mockRoleRepository = new Mock<IRoleRepository>();
            var mockMapper = new Mock<IMapper>();

            var userDto = new CreateUserDTO()
            {
                FirstName = "A",
                LastName = "Nguyen Van",
                DateOfBirth = new DateTime(2000, 1, 1),
                Gender = 0,
                JoinedDate = new DateTime(2022, 10, 25),
                Type = 1
            };

            var existUser = new User()
            {
                UserName = "anv"
            };

            var user = new User()
            {
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                DateOfBirth = userDto.DateOfBirth,
                Gender = userDto.Gender == 1,
                JoinedDate = userDto.JoinedDate
            };

            var admin = new User()
            {
                LocationId = 1,
                UserName = "Admin"
            };

            var role = new Role()
            {
                Id = 1,
                Name = "Admin",
            };

            mockMapper.Setup(m => m.Map<User>(It.IsAny<CreateUserDTO>())).Returns(user);

            mockUserManager.Setup(u => u.FindByNameAsync("anv")).Returns(Task.FromResult(existUser));

            mockUserManager.Setup(u => u.FindByNameAsync("anv1")).Returns(Task.FromResult<User>(null));

            mockUserManager.Setup(u => u.FindByNameAsync("Admin")).Returns(Task.FromResult(admin));

            mockRoleRepository.Setup(r => r.GetRoleByIdAsync(It.IsAny<int>())).Returns(Task.FromResult(role));

            mockUserManager.Setup(u => u.CreateAsync(It.IsAny<User>(), It.IsAny<string>())).Returns(Task.FromResult(IdentityResult.Success));

            mockUserManager.Setup(u => u.AddToRoleAsync(It.IsAny<User>(), It.IsAny<string>())).Returns(Task.FromResult(IdentityResult.Success));

            var claimUser = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Name, "Admin"),
                new Claim(ClaimTypes.NameIdentifier, "1"),
            }, "mock"));

            var identity = new GenericIdentity(ClaimTypes.Name, "AdminHCM");

            identity.AddClaim(new Claim(ClaimTypes.Role, "Admin"));

            var contextUser = new ClaimsPrincipal(identity);

            var httpContext = new DefaultHttpContext()
            {
                User = claimUser,
            };

            var controllerContext = new ControllerContext()
            {
                HttpContext = httpContext,
            };

            UserController controller = new(mockUserManager.Object, mockMapper.Object, mockRoleRepository.Object) { ControllerContext = controllerContext };

            var result = await controller.CreateUser(userDto) as OkObjectResult;

            Assert.IsType<OkObjectResult>(result);

            Assert.Equal(SuccessCode.CREATE_USER_SUCCESSFULLY, result.Value);
        }

        [Fact]
        public async Task Test_User_CreateUser_With_DOB_UNDER_18_Return_BadRequest()
        {
            var mockUserManager = new Mock<FakeUserManager>();
            var mockRoleRepository = new Mock<IRoleRepository>();
            var mockMapper = new Mock<IMapper>();

            var userDto = new CreateUserDTO()
            {
                FirstName = "A",
                LastName = "Nguyen Van",
                DateOfBirth = new DateTime(2022,10,25),
                Gender = 0,
                JoinedDate = new DateTime(2022, 10, 25),
                Type = 1
            };

            UserController controller = new(mockUserManager.Object, mockMapper.Object, mockRoleRepository.Object);

            var result = await controller.CreateUser(userDto) as BadRequestObjectResult;

            Assert.IsType<BadRequestObjectResult>(result);

            Assert.Equal(ErrorCode.USER_UNDER_18, result.Value);
        }

        [Fact]
        public async Task Test_User_CreateUser_With_JOINED_DATE_IS_SAT_OR_SUN_Return_BadRequest()
        {
            var mockUserManager = new Mock<FakeUserManager>();
            var mockRoleRepository = new Mock<IRoleRepository>();
            var mockMapper = new Mock<IMapper>();

            var userDto = new CreateUserDTO()
            {
                FirstName = "A",
                LastName = "Nguyen Van",
                DateOfBirth = new DateTime(2000, 10, 25),
                Gender = 0,
                JoinedDate = new DateTime(2022, 7, 24),
                Type = 1
            };

            UserController controller = new(mockUserManager.Object, mockMapper.Object, mockRoleRepository.Object);

            var result = await controller.CreateUser(userDto) as BadRequestObjectResult;

            Assert.IsType<BadRequestObjectResult>(result);

            Assert.Equal(ErrorCode.JOINED_DATE_IS_SATURDAY_OR_SUNDAY, result.Value);
        }

        [Fact]
        public async Task Test_User_CreateUser_With_ROLE_IS_NULL_Return_BadRequest()
        {
            var mockUserManager = new Mock<FakeUserManager>();
            var mockRoleRepository = new Mock<IRoleRepository>();
            var mockMapper = new Mock<IMapper>();

            var userDto = new CreateUserDTO()
            {
                FirstName = "A",
                LastName = "Nguyen Van",
                DateOfBirth = new DateTime(2000, 10, 25),
                Gender = 0,
                JoinedDate = new DateTime(2022, 7, 25),
                Type = 0
            };

            var user = new User()
            {
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                DateOfBirth = userDto.DateOfBirth,
                Gender = userDto.Gender == 1,
                JoinedDate = userDto.JoinedDate
            };

            var admin = new User()
            {
                LocationId = 1,
                UserName = "Admin"
            };

            var role = new Role()
            {
                Id = 1,
                Name = "Admin",
            };

            mockMapper.Setup(m => m.Map<User>(It.IsAny<CreateUserDTO>())).Returns(user);

            mockUserManager.Setup(u => u.FindByNameAsync(It.IsAny<string>())).Returns(Task.FromResult<User>(null));

            mockUserManager.Setup(u => u.FindByNameAsync("Admin")).Returns(Task.FromResult(admin));

            mockRoleRepository.Setup(r => r.GetRoleByIdAsync(It.IsAny<int>())).Returns(Task.FromResult<Role>(null));

            var claimUser = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Name, "Admin"),
                new Claim(ClaimTypes.NameIdentifier, "1"),
            }, "mock"));

            var identity = new GenericIdentity(ClaimTypes.Name, "AdminHCM");

            identity.AddClaim(new Claim(ClaimTypes.Role, "Admin"));

            var contextUser = new ClaimsPrincipal(identity);

            var httpContext = new DefaultHttpContext()
            {
                User = claimUser,
            };

            var controllerContext = new ControllerContext()
            {
                HttpContext = httpContext,
            };

            UserController controller = new(mockUserManager.Object, mockMapper.Object, mockRoleRepository.Object) { ControllerContext = controllerContext };

            var result = await controller.CreateUser(userDto) as NotFoundObjectResult;

            Assert.IsType<NotFoundObjectResult>(result);

            Assert.Equal(ErrorCode.ROLE_NOT_FOUND, result.Value);
        }

        [Fact]
        public async Task Test_User_CreateUser_With_Failure_Identity_Result_Return_BadRequest()
        {
            var mockUserManager = new Mock<FakeUserManager>();
            var mockRoleRepository = new Mock<IRoleRepository>();
            var mockMapper = new Mock<IMapper>();

            var userDto = new CreateUserDTO()
            {
                FirstName = "A",
                LastName = "Nguyen Van",
                DateOfBirth = new DateTime(2000, 10, 25),
                Gender = 0,
                JoinedDate = new DateTime(2022, 7, 25),
                Type = 0
            };

            var user = new User()
            {
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                DateOfBirth = userDto.DateOfBirth,
                Gender = userDto.Gender == 1,
                JoinedDate = userDto.JoinedDate
            };

            var admin = new User()
            {
                LocationId = 1,
                UserName = "Admin"
            };

            var role = new Role()
            {
                Id = 1,
                Name = "Admin",
            };

            mockMapper.Setup(m => m.Map<User>(It.IsAny<CreateUserDTO>())).Returns(user);

            mockUserManager.Setup(u => u.FindByNameAsync(It.IsAny<string>())).Returns(Task.FromResult<User>(null));

            mockUserManager.Setup(u => u.FindByNameAsync("Admin")).Returns(Task.FromResult(admin));

            mockRoleRepository.Setup(r => r.GetRoleByIdAsync(It.IsAny<int>())).Returns(Task.FromResult(role));

            mockUserManager.Setup(u => u.CreateAsync(It.IsAny<User>(), It.IsAny<string>())).Returns(Task.FromResult(IdentityResult.Failed()));

            var claimUser = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Name, "Admin"),
                new Claim(ClaimTypes.NameIdentifier, "1"),
            }, "mock"));

            var identity = new GenericIdentity(ClaimTypes.Name, "AdminHCM");

            identity.AddClaim(new Claim(ClaimTypes.Role, "Admin"));

            var contextUser = new ClaimsPrincipal(identity);

            var httpContext = new DefaultHttpContext()
            {
                User = claimUser,
            };

            var controllerContext = new ControllerContext()
            {
                HttpContext = httpContext,
            };

            UserController controller = new(mockUserManager.Object, mockMapper.Object, mockRoleRepository.Object) { ControllerContext = controllerContext };

            var result = await controller.CreateUser(userDto) as BadRequestObjectResult;

            Assert.IsType<BadRequestObjectResult>(result);

            Assert.Equal(ErrorCode.CREATE_USER_FAILED, result.Value);
        }

        [Fact]
        public async Task Test_User_CreateUser_With_Add_User_To_Role_Failure_Identity_Result_Return_BadRequest()
        {
            var mockUserManager = new Mock<FakeUserManager>();
            var mockRoleRepository = new Mock<IRoleRepository>();
            var mockMapper = new Mock<IMapper>();

            var userDto = new CreateUserDTO()
            {
                FirstName = "A",
                LastName = "Nguyen Van",
                DateOfBirth = new DateTime(2000, 10, 25),
                Gender = 0,
                JoinedDate = new DateTime(2022, 7, 25),
                Type = 0
            };

            var user = new User()
            {
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                DateOfBirth = userDto.DateOfBirth,
                Gender = userDto.Gender == 1,
                JoinedDate = userDto.JoinedDate
            };

            var admin = new User()
            {
                LocationId = 1,
                UserName = "Admin"
            };

            var role = new Role()
            {
                Id = 1,
                Name = "Admin",
            };

            mockMapper.Setup(m => m.Map<User>(It.IsAny<CreateUserDTO>())).Returns(user);

            mockUserManager.Setup(u => u.FindByNameAsync(It.IsAny<string>())).Returns(Task.FromResult<User>(null));

            mockUserManager.Setup(u => u.FindByNameAsync("Admin")).Returns(Task.FromResult(admin));

            mockRoleRepository.Setup(r => r.GetRoleByIdAsync(It.IsAny<int>())).Returns(Task.FromResult(role));

            mockUserManager.Setup(u => u.CreateAsync(It.IsAny<User>(), It.IsAny<string>())).Returns(Task.FromResult(IdentityResult.Success));

            mockUserManager.Setup(u => u.AddToRoleAsync(It.IsAny<User>(), It.IsAny<string>())).Returns(Task.FromResult(IdentityResult.Failed()));

            var claimUser = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Name, "Admin"),
                new Claim(ClaimTypes.NameIdentifier, "1"),
            }, "mock"));

            var identity = new GenericIdentity(ClaimTypes.Name, "AdminHCM");

            identity.AddClaim(new Claim(ClaimTypes.Role, "Admin"));

            var contextUser = new ClaimsPrincipal(identity);

            var httpContext = new DefaultHttpContext()
            {
                User = claimUser,
            };

            var controllerContext = new ControllerContext()
            {
                HttpContext = httpContext,
            };

            UserController controller = new(mockUserManager.Object, mockMapper.Object, mockRoleRepository.Object) { ControllerContext = controllerContext };

            var result = await controller.CreateUser(userDto) as BadRequestObjectResult;

            Assert.IsType<BadRequestObjectResult>(result);

            Assert.Equal(ErrorCode.ADD_USER_TO_ROLE_FAILED, result.Value);
        }
    }
}
