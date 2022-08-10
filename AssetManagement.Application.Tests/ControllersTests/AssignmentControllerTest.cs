using AssetManagement.Application.Controllers;
using AssetManagement.Contracts.AssignmentDTO;
using AssetManagement.Contracts.Constant;
using AssetManagement.Data.Repositories;
using AssetManagement.Domain.Model;
using AssetManagement.Domain.Model.Enums;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System.Security.Claims;
using System.Security.Principal;

namespace AssetManagement.Application.Tests.ControllersTests
{
    public class AssignmentControllerTest
    {
        [Fact]
        public async Task GetAssignmentList_WhenSuccess_ReturnOkObject()
        {
            //Arrange
            var sorting = new AssignmentParameters() { Searching = "vinz", State = new List<int>(new int[2] { 1,2 }), AssignDate = new DateTime() }; ;

            IEnumerable<Assignment> assignmentList = GenerateListAssignment(10);

            IEnumerable<AssignmentDTO> assignmentListDTO = new List<AssignmentDTO>()
            {
                new AssignmentDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignedTo="vinz",AssignedBy="vu"},
                new AssignmentDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignedTo="vinz",AssignedBy="vu"}
            };

            var assignmentRepositoryMock = new Mock<IAssignmentRepository>();
            assignmentRepositoryMock.Setup(x => x.GetAsync(sorting.Searching,sorting.AssignDate,sorting.State, It.IsAny<string>())).Returns(Task.FromResult(assignmentList));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<IEnumerable<AssignmentDTO>>(assignmentList)).Returns(assignmentListDTO);

            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();

            var controller = new AssignmentController(assignmentRepositoryMock.Object, mockAssetRepository.Object,mockUserManager.Object,mapperMock.Object,mockLogger.Object);

            // Act
            var result = (await controller.GetAssignments(sorting)) as OkObjectResult;

            // Assert
            Assert.NotNull(result);

            var data = result.Value as IEnumerable<AssignmentDTO>;
            Assert.NotNull(data);
            Assert.Equal(assignmentListDTO, data);
        }


        [Fact]
        public async Task GetAssignmentList_WhenNotFoundAssignments_ReturnNotFoundObject()
        {
            //Arrange
            var sorting = new AssignmentParameters() { Searching = "vinz", State = new List<int>(new int[2] { 1, 2 }), AssignDate = new DateTime() }; ;
            var expectedMessage = "Assignment List Empty";

            IEnumerable<Assignment> assignmentList = GenerateListAssignment(10);

            IEnumerable<AssignmentDTO> assignmentListDTO = new List<AssignmentDTO>()
            {
                new AssignmentDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignedTo="vinz",AssignedBy="vu"},
                new AssignmentDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignedTo="vinz",AssignedBy="vu"}
            };

            var assignmentRepositoryMock = new Mock<IAssignmentRepository>();
            assignmentRepositoryMock.Setup(x => x.GetAsync(sorting.Searching, sorting.AssignDate, sorting.State, It.IsAny<string>() ));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<IEnumerable<AssignmentDTO>>(assignmentList)).Returns(assignmentListDTO);

            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();

            var controller = new AssignmentController(assignmentRepositoryMock.Object, mockAssetRepository.Object, mockUserManager.Object, mapperMock.Object, mockLogger.Object);

            // Act
            var result = (await controller.GetAssignments(sorting)) as NotFoundObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedMessage, result.Value.ToString());
        }


        [Fact]
        public async Task GetAssignmentList_WhenThrowError_ReturnBadRequestObject()
        {
            //Arrange
            var sorting = new AssignmentParameters() { Searching = "vinz", State = new List<int>(new int[2] { 1, 2 }), AssignDate = new DateTime() }; ;
            var expectedMessage = "Something went wrong";

            IEnumerable<Assignment> assignmentList = GenerateListAssignment(10).AsEnumerable();

            IEnumerable<AssignmentDTO> assignmentListDTO = new List<AssignmentDTO>()
            {
                new AssignmentDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignedTo="vinz",AssignedBy="vu"},
                new AssignmentDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignedTo="vinz",AssignedBy="vu"}
            };

            var assignmentRepositoryMock = new Mock<IAssignmentRepository>();
            assignmentRepositoryMock.Setup(x => x.GetAsync(sorting.Searching, sorting.AssignDate, sorting.State, It.IsAny<string>())).Throws(new Exception(expectedMessage));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<IEnumerable<AssignmentDTO>>(assignmentList)).Returns(assignmentListDTO);

            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();

            var controller = new AssignmentController(assignmentRepositoryMock.Object, mockAssetRepository.Object, mockUserManager.Object, mapperMock.Object, mockLogger.Object);

            // Act
            var result = (await controller.GetAssignments(sorting)) as BadRequestObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedMessage, result.Value.ToString());
        }

        [Fact]
        public async Task CreateAssignment_Return_SuccessCode()
        {
            var mockAssignmentRepository = new Mock<IAssignmentRepository>();
            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();
            var mockMapper = new Mock<IMapper>();

            var createAssigmentDto = new CreateAssignmentDTO { AssetId = 1, AssignedDate = DateTime.Now, UserId = 2, Note = String.Empty};

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

            var admin = new User()
            {
                Id = 1,
                UserName = "Admin"
            };

            var user = new User()
            {
                Id = 2,
                UserName = "User"
            };

            var asset = new Asset()
            {
                Id = 1,
                Name = "Laptop A",
                StateID = 2
            };

            var assignment = new Assignment()
            {
                Id = 1,
                AssignedBy = admin,
                AssignedTo = user,
                Asset =asset,
                AssignedDate = createAssigmentDto.AssignedDate,
                Note = createAssigmentDto.Note
            };


            mockUserManager.Setup(u => u.FindByNameAsync(It.IsAny<string>())).Returns(Task.FromResult(admin));

            mockUserManager.Setup(u => u.FindByIdAsync(It.IsAny<string>())).Returns(Task.FromResult(user));

            mockAssetRepository.Setup(a => a.GetByAssetIdAsync(It.IsAny<int>())).Returns(Task.FromResult(asset));

            mockAssignmentRepository.Setup(a => a.CreateAssignment(It.IsAny<User>(),
                                                                   It.IsAny<User>(),
                                                                   It.IsAny<Asset>(),
                                                                   It.IsAny<DateTime>(),
                                                                   It.IsAny<string>())).Returns(Task.FromResult(assignment));

            var controller = new AssignmentController(mockAssignmentRepository.Object,
                                                      mockAssetRepository.Object,
                                                      mockUserManager.Object,
                                                      mockMapper.Object,
                                                      mockLogger.Object) { ControllerContext = controllerContext };

            var result = await controller.CreateAssignment(createAssigmentDto) as OkObjectResult;
            
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(SuccessCode.CREATE_ASSIGNMENT_SUCCESSFULLY, result.Value);

        }

        [Fact]
        public async Task CreateAssignment_With_User_Not_Exists_Return_NotFound_With_ErrorCode()
        {
            var mockAssignmentRepository = new Mock<IAssignmentRepository>();
            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();
            var mockMapper = new Mock<IMapper>();

            var createAssigmentDto = new CreateAssignmentDTO { AssetId = 1, AssignedDate = DateTime.Now, UserId = 2, Note = String.Empty };

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

            var admin = new User()
            {
                Id = 1,
                UserName = "Admin"
            };

            mockUserManager.Setup(u => u.FindByNameAsync(It.IsAny<string>())).Returns(Task.FromResult(admin));

            mockUserManager.Setup(u => u.FindByIdAsync(It.IsAny<string>())).Returns(Task.FromResult<User>(null));

            var controller = new AssignmentController(mockAssignmentRepository.Object,
                                                      mockAssetRepository.Object,
                                                      mockUserManager.Object,
                                                      mockMapper.Object,
                                                      mockLogger.Object)
            { ControllerContext = controllerContext };

            var result = await controller.CreateAssignment(createAssigmentDto) as NotFoundObjectResult;

            Assert.IsType<NotFoundObjectResult>(result);
            Assert.Equal(ErrorCode.USER_NOT_FOUND, result.Value);
        }

        [Fact]
        public async Task CreateAssignment_With_Asset_Not_Exists_Return_NotFound_With_ErrorCode()
        {
            var mockAssignmentRepository = new Mock<IAssignmentRepository>();
            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();
            var mockMapper = new Mock<IMapper>();

            var createAssigmentDto = new CreateAssignmentDTO { AssetId = 1, AssignedDate = DateTime.Now, UserId = 2, Note = String.Empty };

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

            var admin = new User()
            {
                Id = 1,
                UserName = "Admin"
            };

            var user = new User()
            {
                Id = 2,
                UserName = "User"
            };

            mockUserManager.Setup(u => u.FindByNameAsync(It.IsAny<string>())).Returns(Task.FromResult(admin));

            mockUserManager.Setup(u => u.FindByIdAsync(It.IsAny<string>())).Returns(Task.FromResult<User>(user));

            mockAssetRepository.Setup(u => u.GetByAssetIdAsync(It.IsAny<int>())).Returns(Task.FromResult<Asset?>(null));

            var controller = new AssignmentController(mockAssignmentRepository.Object,
                                                      mockAssetRepository.Object,
                                                      mockUserManager.Object,
                                                      mockMapper.Object,
                                                      mockLogger.Object)
            { ControllerContext = controllerContext };

            var result = await controller.CreateAssignment(createAssigmentDto) as NotFoundObjectResult;

            Assert.IsType<NotFoundObjectResult>(result);
            Assert.Equal(ErrorCode.ASSET_NOT_FOUND, result.Value);
        }

        [Fact]
        public async Task CreateAssignment_With_Asset_Not_Available_Return_BadRequest_With_ErrorCode()
        {
            var mockAssignmentRepository = new Mock<IAssignmentRepository>();
            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();
            var mockMapper = new Mock<IMapper>();

            var createAssigmentDto = new CreateAssignmentDTO { AssetId = 1, AssignedDate = DateTime.Now, UserId = 2, Note = String.Empty };

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

            var admin = new User()
            {
                Id = 1,
                UserName = "Admin"
            };

            var user = new User()
            {
                Id = 2,
                UserName = "User"
            };

            var asset = new Asset()
            {
                Id = 1,
                Name = "Laptop A",
                StateID = 1 //Asset already assigned
            };

            mockUserManager.Setup(u => u.FindByNameAsync(It.IsAny<string>())).Returns(Task.FromResult(admin));

            mockUserManager.Setup(u => u.FindByIdAsync(It.IsAny<string>())).Returns(Task.FromResult(user));

            mockAssetRepository.Setup(a => a.GetByAssetIdAsync(It.IsAny<int>())).Returns(Task.FromResult(asset));

            var controller = new AssignmentController(mockAssignmentRepository.Object,
                                                      mockAssetRepository.Object,
                                                      mockUserManager.Object,
                                                      mockMapper.Object,
                                                      mockLogger.Object)
            { ControllerContext = controllerContext };

            var result = await controller.CreateAssignment(createAssigmentDto) as BadRequestObjectResult;

            Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal(ErrorCode.ASSET_IS_NOT_AVAILABLE, result.Value);
        }

        [Fact]
        public async Task CreateAssignment_With_Create_Assignemt_Failed_Return_BadRequest_With_ErrorCode()
        {
            var mockAssignmentRepository = new Mock<IAssignmentRepository>();
            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();
            var mockMapper = new Mock<IMapper>();

            var createAssigmentDto = new CreateAssignmentDTO { AssetId = 1, AssignedDate = DateTime.Now, UserId = 2, Note = String.Empty };

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

            var admin = new User()
            {
                Id = 1,
                UserName = "Admin"
            };

            var user = new User()
            {
                Id = 2,
                UserName = "User"
            };

            var asset = new Asset()
            {
                Id = 1,
                Name = "Laptop A",
                StateID = 2
            };

            mockUserManager.Setup(u => u.FindByNameAsync(It.IsAny<string>())).Returns(Task.FromResult(admin));

            mockUserManager.Setup(u => u.FindByIdAsync(It.IsAny<string>())).Returns(Task.FromResult<User>(user));

            mockAssetRepository.Setup(a => a.GetByAssetIdAsync(It.IsAny<int>())).Returns(Task.FromResult(asset));

            mockAssignmentRepository.Setup(a => a.CreateAssignment(It.IsAny<User>(),
                                                                   It.IsAny<User>(),
                                                                   It.IsAny<Asset>(),
                                                                   It.IsAny<DateTime>(),
                                                                   It.IsAny<string>())).Returns(Task.FromResult<Assignment>(null));

            var controller = new AssignmentController(mockAssignmentRepository.Object,
                                                      mockAssetRepository.Object,
                                                      mockUserManager.Object,
                                                      mockMapper.Object,
                                                      mockLogger.Object)
            { ControllerContext = controllerContext };

            var result = await controller.CreateAssignment(createAssigmentDto) as BadRequestObjectResult;

            Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal(ErrorCode.CREATE_ASSIGNMENT_FAILED, result.Value);
        }

        private List<Assignment> GenerateListAssignment(int number)
        {
            var list = new List<Assignment>();
            for (int i = 1; i <= number; i++)
            {
                list.Add(new Assignment
                {
                    Id = i,
                    Asset = new Asset {Id = 1, Code = "LA000001" },
                    AssetId = 1,
                    AssignedTo = new User { Id = 2, UserName = "vinz"},
                    AssignedBy = new User { Id = 1, UserName = "vu"},
                    AssignedDate = DateTime.Now,
                    AssignedState = AssignmentStateEnums.Accepted
                });
            }
            return list;
        }
    }
}
