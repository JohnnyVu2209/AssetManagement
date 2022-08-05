using AssetManagement.Application.Controllers;
using AssetManagement.Contracts.Constant;
using AssetManagement.Contracts.UserDTO;
using AssetManagement.Data.Repositories;
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

            UserController controller = new(mockUserManager.Object, mockMapper.Object, mockRoleRepository.Object, null) { ControllerContext = controllerContext };

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

            UserController controller = new(mockUserManager.Object, mockMapper.Object, mockRoleRepository.Object, null) { ControllerContext = controllerContext };

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

            UserController controller = new(mockUserManager.Object, mockMapper.Object, mockRoleRepository.Object, null);

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

            UserController controller = new(mockUserManager.Object, mockMapper.Object, mockRoleRepository.Object, null);

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

            UserController controller = new(mockUserManager.Object, mockMapper.Object, mockRoleRepository.Object, null) { ControllerContext = controllerContext };

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

            UserController controller = new(mockUserManager.Object, mockMapper.Object, mockRoleRepository.Object, null) { ControllerContext = controllerContext };

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

            UserController controller = new(mockUserManager.Object, mockMapper.Object, mockRoleRepository.Object, null) { ControllerContext = controllerContext };

            var result = await controller.CreateUser(userDto) as BadRequestObjectResult;

            Assert.IsType<BadRequestObjectResult>(result);

            Assert.Equal(ErrorCode.ADD_USER_TO_ROLE_FAILED, result.Value);
        }

        [Fact]
        public async void GetAllPaging_ReturnsOk()
        {
            var pageResult = new PageResult<UserViewDTO>()
            {
                Items = new List<UserViewDTO>(),
                Page = 1,
                Limit = 10,
                TotalRecords = 10
            };

            var mockUserManager = new Mock<FakeUserManager>();
            var mockRoleRepository = new Mock<IRoleRepository>();
            var mockMapper = new Mock<IMapper>();
            var mockUserRepository = new Mock<IUserRepository>();

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

            mockUserRepository.Setup(u => u.GetPaginationAsync(It.IsAny<ViewUserRequest>())).Returns(Task.FromResult(pageResult));

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

            UserController controller = new(mockUserManager.Object, mockMapper.Object, mockRoleRepository.Object, mockUserRepository.Object) { ControllerContext = controllerContext };

            OkObjectResult result = await controller.GetPagination(new ViewUserRequest()) as OkObjectResult;

            var content = result.Value;

            Assert.IsType<OkObjectResult>(result);
            Assert.IsType<PageResult<UserViewDTO>>(content);
        }

        [Fact]
        public async void GetAllPaging_ReturnsBadRequest()
        {
            var pageResult = new PageResult<UserViewDTO>()
            {
                Items = null,
                Page = 1,
                Limit = 10,
                TotalRecords = 10
            };

            var mockUserManager = new Mock<FakeUserManager>();
            var mockRoleRepository = new Mock<IRoleRepository>();
            var mockMapper = new Mock<IMapper>();
            var mockUserRepository = new Mock<IUserRepository>();

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

            mockUserRepository.Setup(u => u.GetPaginationAsync(It.IsAny<ViewUserRequest>())).Returns(Task.FromResult(pageResult));

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

            UserController controller = new(mockUserManager.Object, mockMapper.Object, mockRoleRepository.Object, mockUserRepository.Object) { ControllerContext = controllerContext };

            var result = await controller.GetPagination(new ViewUserRequest());

            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async void GetByStaffCode_ReturnsOk()
        {
            var mockData = new UserViewDTO()
            {
                Id = 2,
                StaffCode = "SD0002",
                FirstName = "Nguyen Tung",
                LastName = "Lam",
                UserName = "lamnt",
                DateOfBirth = DateTime.Now,
                Gender = 0,
                JoinedDate = DateTime.Now,
                Type = "User",
                LocationId = 1,
                LocationName = "Hà Nội"
            };

            var mockUserManager = new Mock<FakeUserManager>();
            var mockRoleRepository = new Mock<IRoleRepository>();
            var mockMapper = new Mock<IMapper>();
            var mockUserRepository = new Mock<IUserRepository>();

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

            mockUserRepository.Setup(u => u.GetByStaffCodeAsync(It.IsAny<string>())).Returns(Task.FromResult(mockData));

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

            UserController controller = new(mockUserManager.Object, mockMapper.Object, mockRoleRepository.Object, mockUserRepository.Object) { ControllerContext = controllerContext };

            OkObjectResult result = await controller.GetByStaffCode("SD0001") as OkObjectResult;

            var content = result.Value;

            Assert.IsType<OkObjectResult>(result);
            Assert.IsType<UserViewDTO>(content);
        }

        [Fact]
        public async void GetByStaffCode_ReturnsNotFound()
        {
            var mockUserManager = new Mock<FakeUserManager>();
            var mockRoleRepository = new Mock<IRoleRepository>();
            var mockMapper = new Mock<IMapper>();
            var mockUserRepository = new Mock<IUserRepository>();

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

            mockUserRepository.Setup(u => u.GetByStaffCodeAsync(It.IsAny<string>()));

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

            UserController controller = new(mockUserManager.Object, mockMapper.Object, mockRoleRepository.Object, mockUserRepository.Object) { ControllerContext = controllerContext };

            NotFoundResult result = await controller.GetByStaffCode("SD000000000") as NotFoundResult;

            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async void UpdateUser_ReturnsOk()
        {
            var pageResult = new ApiResult<string>(null)
            {
                StatusCode = 200,
                Message = "Update user information successfully!"
            };

            var mockUserManager = new Mock<FakeUserManager>();
            var mockRoleRepository = new Mock<IRoleRepository>();
            var mockMapper = new Mock<IMapper>();
            var mockUserRepository = new Mock<IUserRepository>();

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

            mockUserRepository.Setup(u => u.UpdateAsync(It.IsAny<UpdateUserRequest>())).Returns(Task.FromResult(pageResult));

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

            UserController controller = new(mockUserManager.Object, mockMapper.Object, mockRoleRepository.Object, mockUserRepository.Object) { ControllerContext = controllerContext };


            OkObjectResult result = await controller.Update(new UpdateUserRequest()) as OkObjectResult;

            Assert.IsType<OkObjectResult>(result);
            Assert.Equal("Update user information successfully!", result.Value.ToString());
            Assert.Equal(200, result.StatusCode);
        }

        [Fact]
        public async void UpdateUser_ReturnsBadRequest_UserUnder18()
        {
            var pageResult = new ApiResult<string>(null)
            {
                StatusCode = 400,
                Message = "User is under 18"
            };

            var mockUserManager = new Mock<FakeUserManager>();
            var mockRoleRepository = new Mock<IRoleRepository>();
            var mockMapper = new Mock<IMapper>();
            var mockUserRepository = new Mock<IUserRepository>();

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

            mockUserRepository.Setup(u => u.UpdateAsync(It.IsAny<UpdateUserRequest>())).Returns(Task.FromResult(pageResult));

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

            UserController controller = new(mockUserManager.Object, mockMapper.Object, mockRoleRepository.Object, mockUserRepository.Object) { ControllerContext = controllerContext };


            BadRequestObjectResult result = await controller.Update(new UpdateUserRequest()) as BadRequestObjectResult;

            Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal("User is under 18", result.Value.ToString());
            Assert.Equal(400, result.StatusCode);
        }

        [Fact]
        public async void UpdateUser_ReturnsBadRequest_JoinOnSatOrSun()
        {
            var pageResult = new ApiResult<string>(null)
            {
                StatusCode = 400,
                Message = "Joined date is Sat or Sun!"
            };

            var mockUserManager = new Mock<FakeUserManager>();
            var mockRoleRepository = new Mock<IRoleRepository>();
            var mockMapper = new Mock<IMapper>();
            var mockUserRepository = new Mock<IUserRepository>();

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

            mockUserRepository.Setup(u => u.UpdateAsync(It.IsAny<UpdateUserRequest>())).Returns(Task.FromResult(pageResult));

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

            UserController controller = new(mockUserManager.Object, mockMapper.Object, mockRoleRepository.Object, mockUserRepository.Object) { ControllerContext = controllerContext };


            BadRequestObjectResult result = await controller.Update(new UpdateUserRequest()) as BadRequestObjectResult;

            Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal("Joined date is Sat or Sun!", result.Value.ToString());
            Assert.Equal(400, result.StatusCode);
        }

        [Fact]
        public async void GetRoles_ReturnsOk()
        {
            var mockData = new List<RoleViewModel>()
            {
                new RoleViewModel()
                {
                    Id = 1,
                    Name = "Admin",
                },
                new RoleViewModel()
                {
                    Id = 2,
                    Name = "User",
                }
            };
            var mockUserManager = new Mock<FakeUserManager>();
            var mockRoleRepository = new Mock<IRoleRepository>();
            var mockMapper = new Mock<IMapper>();
            var mockUserRepository = new Mock<IUserRepository>();

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

            mockUserRepository.Setup(u => u.GetRolesAsync()).Returns(Task.FromResult(mockData));

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

            UserController controller = new(mockUserManager.Object, mockMapper.Object, mockRoleRepository.Object, mockUserRepository.Object) { ControllerContext = controllerContext };


            OkObjectResult result = await controller.GetRoles() as OkObjectResult;

            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async void GetRoles_ReturnsBadRequest()
        {
            var mockUserManager = new Mock<FakeUserManager>();
            var mockRoleRepository = new Mock<IRoleRepository>();
            var mockMapper = new Mock<IMapper>();
            var mockUserRepository = new Mock<IUserRepository>();

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

            mockUserRepository.Setup(u => u.GetRolesAsync());

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

            UserController controller = new(mockUserManager.Object, mockMapper.Object, mockRoleRepository.Object, mockUserRepository.Object) { ControllerContext = controllerContext };


            BadRequestResult result = await controller.GetRoles() as BadRequestResult;

            Assert.IsType<BadRequestResult>(result);
        }
    }
}
