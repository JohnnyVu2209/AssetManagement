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

            IEnumerable<AssignmentViewDTO> assignmentListDTO = new List<AssignmentViewDTO>()
            {
                new AssignmentViewDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignedTo="vinz",AssignedBy="vu"},
                new AssignmentViewDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignedTo="vinz",AssignedBy="vu"}
            };

            var assignmentRepositoryMock = new Mock<IAssignmentRepository>();
            assignmentRepositoryMock.Setup(x => x.GetAsync(sorting.Searching,sorting.AssignDate,sorting.State, It.IsAny<string>())).Returns(Task.FromResult(assignmentList));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<IEnumerable<AssignmentViewDTO>>(assignmentList)).Returns(assignmentListDTO);

            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();

            var controller = new AssignmentController(assignmentRepositoryMock.Object, mockAssetRepository.Object,mockUserManager.Object,mapperMock.Object,mockLogger.Object);

            // Act
            var result = (await controller.GetAssignments(sorting)) as OkObjectResult;

            // Assert
            Assert.NotNull(result);

            var data = result.Value as IEnumerable<AssignmentViewDTO>;
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

            IEnumerable<AssignmentViewDTO> assignmentListDTO = new List<AssignmentViewDTO>()
            {
                new AssignmentViewDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignedTo="vinz",AssignedBy="vu"},
                new AssignmentViewDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignedTo="vinz",AssignedBy="vu"}
            };

            var assignmentRepositoryMock = new Mock<IAssignmentRepository>();
            assignmentRepositoryMock.Setup(x => x.GetAsync(sorting.Searching, sorting.AssignDate, sorting.State, It.IsAny<string>() ));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<IEnumerable<AssignmentViewDTO>>(assignmentList)).Returns(assignmentListDTO);

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

            IEnumerable<AssignmentViewDTO> assignmentListDTO = new List<AssignmentViewDTO>()
            {
                new AssignmentViewDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignedTo="vinz",AssignedBy="vu"},
                new AssignmentViewDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignedTo="vinz",AssignedBy="vu"}
            };

            var assignmentRepositoryMock = new Mock<IAssignmentRepository>();
            assignmentRepositoryMock.Setup(x => x.GetAsync(sorting.Searching, sorting.AssignDate, sorting.State, It.IsAny<string>())).Throws(new Exception(expectedMessage));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<IEnumerable<AssignmentViewDTO>>(assignmentList)).Returns(assignmentListDTO);

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

            mockAssetRepository.Setup(a => a.GetAssetByIdAsync(It.IsAny<int>())).Returns(Task.FromResult(asset));

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

            mockAssetRepository.Setup(u => u.GetAssetByIdAsync(It.IsAny<int>())).Returns(Task.FromResult<Asset?>(null));

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

            mockAssetRepository.Setup(a => a.GetAssetByIdAsync(It.IsAny<int>())).Returns(Task.FromResult(asset));

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

            mockAssetRepository.Setup(a => a.GetAssetByIdAsync(It.IsAny<int>())).Returns(Task.FromResult(asset));

            mockAssignmentRepository.Setup(a => a.CreateAssignment(It.IsAny<User>(),
                                                                   It.IsAny<User>(),
                                                                   It.IsAny<Asset>(),
                                                                   It.IsAny<DateTime>(),
                                                                   It.IsAny<string>())).Throws(new Exception());

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

        [Fact]
        public async Task GetAssignmentByUserLogin_ReturnOk()
        {
            //Arrange
            IEnumerable<Assignment> assignmentList = GenerateListAssignment(10);
            var pagedResult = new PageResult<UserAssignmentViewModel>()
            {
                TotalRecords = 10,
                Items = new List<UserAssignmentViewModel>(),
                Page = 1,
                Limit = 5
            };

            List<AssignmentViewDTO> assignmentListDTO = new List<AssignmentViewDTO>()
            {
                new AssignmentViewDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignedTo="vinz",AssignedBy="vu"},
                new AssignmentViewDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignedTo="vinz",AssignedBy="vu"}
            };

            var assignmentRepositoryMock = new Mock<IAssignmentRepository>();
            assignmentRepositoryMock.Setup(x => x.GetUserAssignmentPaginationAsync(It.IsAny<UserAssignmentViewRequest>())).Returns(Task.FromResult(pagedResult));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<IEnumerable<AssignmentViewDTO>>(assignmentList)).Returns(assignmentListDTO);

            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();

            var controller = new AssignmentController(assignmentRepositoryMock.Object, mockAssetRepository.Object, mockUserManager.Object, mapperMock.Object, mockLogger.Object);

            // Act
            OkObjectResult result = (await controller.GetAssignmentsByUserLogin(new UserAssignmentViewRequest())) as OkObjectResult;
            var content = result.Value;

            // Assert
            Assert.IsType<OkObjectResult>(result);
            Assert.IsType<PageResult<UserAssignmentViewModel>>(content);
        }

        [Fact]
        public async Task GetAssignmentByUserLogin_ReturnBadRequest()
        {
            //Arrange
            IEnumerable<Assignment> assignmentList = GenerateListAssignment(10);
            List<AssignmentViewDTO> assignmentListDTO = new List<AssignmentViewDTO>()
            {
                new AssignmentViewDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignedTo="vinz",AssignedBy="vu"},
                new AssignmentViewDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignedTo="vinz",AssignedBy="vu"}
            };

            var assignmentRepositoryMock = new Mock<IAssignmentRepository>();
            assignmentRepositoryMock.Setup(x => x.GetUserAssignmentPaginationAsync(It.IsAny<UserAssignmentViewRequest>()));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<IEnumerable<AssignmentViewDTO>>(assignmentList)).Returns(assignmentListDTO);

            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();

            var controller = new AssignmentController(assignmentRepositoryMock.Object, mockAssetRepository.Object, mockUserManager.Object, mapperMock.Object, mockLogger.Object);

            // Act
            BadRequestResult result = (await controller.GetAssignmentsByUserLogin(new UserAssignmentViewRequest())) as BadRequestResult;

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task AcceptRespone_ReturnBadRequest()
        {
            //Arrange
            IEnumerable<Assignment> assignmentList = GenerateListAssignment(10);
            List<AssignmentViewDTO> assignmentListDTO = new List<AssignmentViewDTO>()
            {
                new AssignmentViewDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignedTo="vinz",AssignedBy="vu"},
                new AssignmentViewDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignedTo="vinz",AssignedBy="vu"}
            };
            var expectedResult = new ApiResult<bool>(true)
            {
                Message = "Cannot update state, assignment was accepted",
                StatusCode = 400
            };

            var assignmentRepositoryMock = new Mock<IAssignmentRepository>();
            assignmentRepositoryMock.Setup(x => x.AcceptRespondAsync(It.IsAny<int>())).Returns(Task.FromResult(expectedResult));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<IEnumerable<AssignmentViewDTO>>(assignmentList)).Returns(assignmentListDTO);

            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();

            var controller = new AssignmentController(assignmentRepositoryMock.Object, mockAssetRepository.Object, mockUserManager.Object, mapperMock.Object, mockLogger.Object);

            // Act
            BadRequestObjectResult result = (await controller.AcceptRespond(1)) as BadRequestObjectResult;

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal("Cannot update state, assignment was accepted", result.Value.ToString());
            Assert.Equal(400, result.StatusCode);
        }

        [Fact]
        public async Task AcceptRespone_ReturnOk()
        {
            //Arrange
            IEnumerable<Assignment> assignmentList = GenerateListAssignment(10);
            List<AssignmentViewDTO> assignmentListDTO = new List<AssignmentViewDTO>()
            {
                new AssignmentViewDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignedTo="vinz",AssignedBy="vu"},
                new AssignmentViewDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignedTo="vinz",AssignedBy="vu"}
            };
            var expectedResult = new ApiResult<bool>(true)
            {
                Message = "Assignment is accepted",
                StatusCode = 200
            };

            var assignmentRepositoryMock = new Mock<IAssignmentRepository>();
            assignmentRepositoryMock.Setup(x => x.AcceptRespondAsync(It.IsAny<int>())).Returns(Task.FromResult(expectedResult));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<IEnumerable<AssignmentViewDTO>>(assignmentList)).Returns(assignmentListDTO);

            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();

            var controller = new AssignmentController(assignmentRepositoryMock.Object, mockAssetRepository.Object, mockUserManager.Object, mapperMock.Object, mockLogger.Object);

            // Act
            OkObjectResult result = (await controller.AcceptRespond(1)) as OkObjectResult;

            // Assert
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal("Assignment is accepted", result.Value.ToString());
            Assert.Equal(200, result.StatusCode);
        }

        [Fact]
        public async Task AcceptRespone_NotFound()
        {
            //Arrange
            IEnumerable<Assignment> assignmentList = GenerateListAssignment(10);
            List<AssignmentViewDTO> assignmentListDTO = new List<AssignmentViewDTO>()
            {
                new AssignmentViewDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignedTo="vinz",AssignedBy="vu"},
                new AssignmentViewDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignedTo="vinz",AssignedBy="vu"}
            };
            var expectedResult = new ApiResult<bool>(true)
            {
                Message = "Not found this assignment",
                StatusCode = 404
            };

            var assignmentRepositoryMock = new Mock<IAssignmentRepository>();
            assignmentRepositoryMock.Setup(x => x.AcceptRespondAsync(It.IsAny<int>())).Returns(Task.FromResult(expectedResult));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<IEnumerable<AssignmentViewDTO>>(assignmentList)).Returns(assignmentListDTO);

            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();

            var controller = new AssignmentController(assignmentRepositoryMock.Object, mockAssetRepository.Object, mockUserManager.Object, mapperMock.Object, mockLogger.Object);

            // Act
            NotFoundObjectResult result = (await controller.AcceptRespond(1)) as NotFoundObjectResult;

            // Assert
            Assert.IsType<NotFoundObjectResult>(result);
            Assert.Equal("Not found this assignment", result.Value.ToString());
            Assert.Equal(404, result.StatusCode);
        }

        [Fact]
        public async Task DeclineRespone_ReturnBadRequest()
        {
            //Arrange
            IEnumerable<Assignment> assignmentList = GenerateListAssignment(10);
            List<AssignmentViewDTO> assignmentListDTO = new List<AssignmentViewDTO>()
            {
                new AssignmentViewDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignedTo="vinz",AssignedBy="vu"},
                new AssignmentViewDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignedTo="vinz",AssignedBy="vu"}
            };
            var expectedResult = new ApiResult<bool>(true)
            {
                Message = "Failed, perhaps assignment state was accepted",
                StatusCode = 400
            };

            var assignmentRepositoryMock = new Mock<IAssignmentRepository>();
            assignmentRepositoryMock.Setup(x => x.DeclineRespondAsync(It.IsAny<int>())).Returns(Task.FromResult(expectedResult));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<IEnumerable<AssignmentViewDTO>>(assignmentList)).Returns(assignmentListDTO);

            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();

            var controller = new AssignmentController(assignmentRepositoryMock.Object, mockAssetRepository.Object, mockUserManager.Object, mapperMock.Object, mockLogger.Object);

            // Act
            BadRequestObjectResult result = (await controller.DeclineRespond(1)) as BadRequestObjectResult;

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal("Failed, perhaps assignment state was accepted", result.Value.ToString());
            Assert.Equal(400, result.StatusCode);
        }

        [Fact]
        public async Task DeclineRespone_NotFound()
        {
            //Arrange
            IEnumerable<Assignment> assignmentList = GenerateListAssignment(10);
            List<AssignmentViewDTO> assignmentListDTO = new List<AssignmentViewDTO>()
            {
                new AssignmentViewDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignedTo="vinz",AssignedBy="vu"},
                new AssignmentViewDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignedTo="vinz",AssignedBy="vu"}
            };
            var expectedResult = new ApiResult<bool>(true)
            {
                Message = "Assignment is not found",
                StatusCode = 404
            };

            var assignmentRepositoryMock = new Mock<IAssignmentRepository>();
            assignmentRepositoryMock.Setup(x => x.DeclineRespondAsync(It.IsAny<int>())).Returns(Task.FromResult(expectedResult));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<IEnumerable<AssignmentViewDTO>>(assignmentList)).Returns(assignmentListDTO);

            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();

            var controller = new AssignmentController(assignmentRepositoryMock.Object, mockAssetRepository.Object, mockUserManager.Object, mapperMock.Object, mockLogger.Object);

            // Act
            NotFoundObjectResult result = (await controller.DeclineRespond(1)) as NotFoundObjectResult;

            // Assert
            Assert.IsType<NotFoundObjectResult>(result);
            Assert.Equal("Assignment is not found", result.Value.ToString());
            Assert.Equal(404, result.StatusCode);
        }

        [Fact]
        public async Task DeclineRespone_ReturnOk()
        {
            //Arrange
            IEnumerable<Assignment> assignmentList = GenerateListAssignment(10);
            List<AssignmentViewDTO> assignmentListDTO = new List<AssignmentViewDTO>()
            {
                new AssignmentViewDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignedTo="vinz",AssignedBy="vu"},
                new AssignmentViewDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignedTo="vinz",AssignedBy="vu"}
            };
            var expectedResult = new ApiResult<bool>(true)
            {
                Message = "Remove assignment successfully",
                StatusCode = 200
            };

            var assignmentRepositoryMock = new Mock<IAssignmentRepository>();
            assignmentRepositoryMock.Setup(x => x.DeclineRespondAsync(It.IsAny<int>())).Returns(Task.FromResult(expectedResult));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<IEnumerable<AssignmentViewDTO>>(assignmentList)).Returns(assignmentListDTO);

            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();

            var controller = new AssignmentController(assignmentRepositoryMock.Object, mockAssetRepository.Object, mockUserManager.Object, mapperMock.Object, mockLogger.Object);

            // Act
            OkObjectResult result = (await controller.DeclineRespond(1)) as OkObjectResult;

            // Assert
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal("Remove assignment successfully", result.Value.ToString());
            Assert.Equal(200, result.StatusCode);
        }

        //Get Assignment By Id
        [Fact]
        public async void GetAssignmentById_WhenSuccess_ReturnsOkObject()
        {

            //Arrange
            var sorting = new AssignmentParameters() { Searching = "vinz", State = new List<int>(new int[2] { 1, 2 }), AssignDate = new DateTime() }; ;
            var expectedResult = new Assignment()
            {
                AssetId = 1,
                AssignedToId = 1,
                AssignedById = 1,
                AssignedDate = DateTime.Now,
                AssignedState = AssignmentStateEnums.Waiting,
                Note = "ABC",
                Asset = new Asset()
                {
                    Id = 1,
                    Code = "LA000001",
                    Name = "Laptop HP Probook 450 G1",
                    Specification = "Dummy Spec 1",
                    InstalledDate = DateTime.Now,
                    CategoryID = 1,
                    StateID = 1,
                    LocationID = 1,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                },
                AssignedTo = new User()
                {
                    Id = 1,
                    StaffCode = "SD0001",
                    FirstName = "Nghia",
                    LastName = "Dinh Trong",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    UserName = "AdminHCM",
                    NormalizedUserName = "ADMINHCM",
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    LocationId = 1
                },
                AssignedBy = new User()
                {
                    Id = 1,
                    StaffCode = "SD0001",
                    FirstName = "Nghia",
                    LastName = "Dinh Trong",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    UserName = "AdminHCM",
                    NormalizedUserName = "ADMINHCM",
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    LocationId = 1
                },
            };

            var mapperResult = new AssignmentViewDTO { Id = 1, AssetCode = "LA000001", AssetName = "Laptop", AssignedTo = "vinz", AssignedBy = "vu" };
 

            var assignmentRepositoryMock = new Mock<IAssignmentRepository>();
            assignmentRepositoryMock.Setup(x => x.GetAssignmentAsync(It.IsAny<int>())).Returns(Task.FromResult(expectedResult));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<AssignmentViewDTO>(expectedResult)).Returns(mapperResult);

            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();

            var controller = new AssignmentController(assignmentRepositoryMock.Object, mockAssetRepository.Object, mockUserManager.Object, mapperMock.Object, mockLogger.Object);

            // Act
            OkObjectResult result = (await controller.GetAssignmentById(1)) as OkObjectResult;

            // Assert
            Assert.IsType<OkObjectResult>(result);
            Assert.IsType<AssignmentViewDTO>(result.Value);
        }

        [Fact]
        public async void GetAssignmentById_WhenNotFoundAssignment_ReturnsNotFound()
        {

            //Arrange
            var sorting = new AssignmentParameters() { Searching = "vinz", State = new List<int>(new int[2] { 1, 2 }), AssignDate = new DateTime() }; ;

            var mapperResult = new AssignmentViewDTO { Id = 1, AssetCode = "LA000001", AssetName = "Laptop", AssignedTo = "vinz", AssignedBy = "vu" };


            var assignmentRepositoryMock = new Mock<IAssignmentRepository>();
            assignmentRepositoryMock.Setup(x => x.GetAssignmentAsync(It.IsAny<int>()));

            var mapperMock = new Mock<IMapper>();

            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();

            var controller = new AssignmentController(assignmentRepositoryMock.Object, mockAssetRepository.Object, mockUserManager.Object, mapperMock.Object, mockLogger.Object);

            // Act
            NotFoundResult result = (await controller.GetAssignmentById(1)) as NotFoundResult;

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task EditAssignment_Return_SuccessCode()
        {
            var mockAssignmentRepository = new Mock<IAssignmentRepository>();
            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();
            var mockMapper = new Mock<IMapper>();

            var editDto = new CreateAssignmentDTO
            {
                AssetId = 2,
                AssignedDate = DateTime.Now,
                UserId = 2,
                Note = "Test edit"
            };

            var assignment = new Assignment
            {
                AssetId=1,
                AssignedToId = 1,
                AssignedById = 1,
                Note = "unit test",
                AssignedState = AssignmentStateEnums.Waiting
                
            };

            var user = new User
            {
                Id = 2,
                UserName = "userTest2"
            };

            var asset = new Asset
            {
                Id = 2,
                StateID = 2
            };

            var updateAssignment = new Assignment
            {
                AssetId = editDto.AssetId,
                AssignedDate = editDto.AssignedDate,
                AssignedToId = editDto.UserId,
                Note = editDto.Note,
                AssignedById = assignment.AssignedById,
                AssignedState = AssignmentStateEnums.Waiting
            };

            mockAssignmentRepository.Setup(a => a.GetAssignmentAsync(It.IsAny<int>())).Returns(Task.FromResult(assignment));

            mockUserManager.Setup(u => u.FindByIdAsync(It.IsAny<string>())).Returns(Task.FromResult(user));

            mockAssetRepository.Setup(a => a.GetAssetByIdAsync(It.IsAny<int>())).Returns(Task.FromResult<Asset?>(asset));

            mockAssetRepository.Setup(a => a.SetAssetAvailable(It.IsAny<Asset>())).Returns(Task.CompletedTask);

            mockMapper.Setup(m => m.Map(It.IsAny<CreateAssignmentDTO>(), It.IsAny<Assignment>())).Returns(updateAssignment);

            mockAssignmentRepository.Setup(a => a.UpdateAssignment(It.IsAny<Asset>(), It.IsAny<User>(), It.IsAny<Assignment>())).Returns(Task.CompletedTask);

            var controller = new AssignmentController(mockAssignmentRepository.Object,
                                                      mockAssetRepository.Object,
                                                      mockUserManager.Object,
                                                      mockMapper.Object,
                                                      mockLogger.Object);

            var result = await controller.EditAssignment(1, editDto) as OkObjectResult;

            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(SuccessCode.EDIT_ASSIGNMENT_SUCCESSFULLY, result.Value);
        }

        [Fact]
        public async Task EditAssignment_With_Assignment_Is_Null_Return_NotFound_With_ErrorCode()
        {
            var mockAssignmentRepository = new Mock<IAssignmentRepository>();
            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();
            var mockMapper = new Mock<IMapper>();

            var editDto = new CreateAssignmentDTO
            {
                AssetId = 2,
                AssignedDate = DateTime.Now,
                UserId = 2,
                Note = "Test edit"
            };

            mockAssignmentRepository.Setup(a => a.GetAssignmentAsync(It.IsAny<int>())).Returns(Task.FromResult<Assignment>(null));

            var controller = new AssignmentController(mockAssignmentRepository.Object,
                                                     mockAssetRepository.Object,
                                                     mockUserManager.Object,
                                                     mockMapper.Object,
                                                     mockLogger.Object);

            var result = await controller.EditAssignment(1, editDto) as NotFoundObjectResult;

            Assert.IsType<NotFoundObjectResult>(result);
            Assert.Equal(ErrorCode.ASSIGNMENT_NOT_FOUND, result.Value);
        }

        [Fact]
        public async Task EditAssignment_With_Assignment_State_Is_Not_Available_Return_BadRequest_With_ErrorCode()
        {
            var mockAssignmentRepository = new Mock<IAssignmentRepository>();
            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();
            var mockMapper = new Mock<IMapper>();

            var editDto = new CreateAssignmentDTO
            {
                AssetId = 2,
                AssignedDate = DateTime.Now,
                UserId = 2,
                Note = "Test edit"
            };

            var assignment = new Assignment
            {
                AssetId = 1,
                AssignedToId = 1,
                AssignedById = 1,
                Note = "unit test",
                AssignedState = AssignmentStateEnums.Accepted

            };

            mockAssignmentRepository.Setup(a => a.GetAssignmentAsync(It.IsAny<int>())).Returns(Task.FromResult(assignment));

            var controller = new AssignmentController(mockAssignmentRepository.Object,
                                                     mockAssetRepository.Object,
                                                     mockUserManager.Object,
                                                     mockMapper.Object,
                                                     mockLogger.Object);

            var result = await controller.EditAssignment(1, editDto) as BadRequestObjectResult;

            Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal(ErrorCode.ASSIGNMENT_NOT_IN_WAITING_STATE, result.Value);
        }

        [Fact]
        public async Task EditAssignment_With_Assigned_To_Is_Null_Return_NotFound_With_ErrorCode()
        {
            var mockAssignmentRepository = new Mock<IAssignmentRepository>();
            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();
            var mockMapper = new Mock<IMapper>();

            var editDto = new CreateAssignmentDTO
            {
                AssetId = 2,
                AssignedDate = DateTime.Now,
                UserId = 2,
                Note = "Test edit"
            };

            var assignment = new Assignment
            {
                AssetId = 1,
                AssignedToId = 1,
                AssignedById = 1,
                Note = "unit test",
                AssignedState = AssignmentStateEnums.Waiting
            };

            mockAssignmentRepository.Setup(a => a.GetAssignmentAsync(It.IsAny<int>())).Returns(Task.FromResult(assignment));

            mockUserManager.Setup(u => u.FindByIdAsync(It.IsAny<string>())).Returns(Task.FromResult<User>(null));

            var controller = new AssignmentController(mockAssignmentRepository.Object,
                                                     mockAssetRepository.Object,
                                                     mockUserManager.Object,
                                                     mockMapper.Object,
                                                     mockLogger.Object);

            var result = await controller.EditAssignment(1, editDto) as NotFoundObjectResult;

            Assert.IsType<NotFoundObjectResult>(result);
            Assert.Equal(ErrorCode.USER_NOT_FOUND, result.Value);
        }

        [Fact]
        public async Task EditAssignment_With_Asset_Is_Null_Return_NotFound_With_ErrorCode()
        {
            var mockAssignmentRepository = new Mock<IAssignmentRepository>();
            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();
            var mockMapper = new Mock<IMapper>();

            var editDto = new CreateAssignmentDTO
            {
                AssetId = 2,
                AssignedDate = DateTime.Now,
                UserId = 2,
                Note = "Test edit"
            };

            var assignment = new Assignment
            {
                AssetId = 1,
                AssignedToId = 1,
                AssignedById = 1,
                Note = "unit test",
                AssignedState = AssignmentStateEnums.Waiting

            };

            var user = new User
            {
                Id = 2,
                UserName = "userTest2"
            };

            mockAssignmentRepository.Setup(a => a.GetAssignmentAsync(It.IsAny<int>())).Returns(Task.FromResult(assignment));

            mockUserManager.Setup(u => u.FindByIdAsync(It.IsAny<string>())).Returns(Task.FromResult(user));

            mockAssetRepository.Setup(a => a.GetAssetByIdAsync(It.IsAny<int>())).Returns(Task.FromResult<Asset?>(null));

            var controller = new AssignmentController(mockAssignmentRepository.Object,
                                                     mockAssetRepository.Object,
                                                     mockUserManager.Object,
                                                     mockMapper.Object,
                                                     mockLogger.Object);

            var result = await controller.EditAssignment(1, editDto) as NotFoundObjectResult;

            Assert.IsType<NotFoundObjectResult>(result);
            Assert.Equal(ErrorCode.ASSET_NOT_FOUND, result.Value);
        }

        [Fact]
        public async Task EditAssignment_With_Asset_Is_Not_Available_Return_BadRequest_With_ErrorCode()
        {
            var mockAssignmentRepository = new Mock<IAssignmentRepository>();
            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();
            var mockMapper = new Mock<IMapper>();

            var editDto = new CreateAssignmentDTO
            {
                AssetId = 2,
                AssignedDate = DateTime.Now,
                UserId = 2,
                Note = "Test edit"
            };

            var assignment = new Assignment
            {
                AssetId = 1,
                AssignedToId = 1,
                AssignedById = 1,
                Note = "unit test",
                AssignedState = AssignmentStateEnums.Waiting

            };

            var user = new User
            {
                Id = 2,
                UserName = "userTest2"
            };

            var asset = new Asset
            {
                Id = 2,
                StateID = 1
            };

            mockAssignmentRepository.Setup(a => a.GetAssignmentAsync(It.IsAny<int>())).Returns(Task.FromResult(assignment));

            mockUserManager.Setup(u => u.FindByIdAsync(It.IsAny<string>())).Returns(Task.FromResult(user));

            mockAssetRepository.Setup(a => a.GetAssetByIdAsync(It.IsAny<int>())).Returns(Task.FromResult<Asset?>(asset));

            var controller = new AssignmentController(mockAssignmentRepository.Object,
                                                     mockAssetRepository.Object,
                                                     mockUserManager.Object,
                                                     mockMapper.Object,
                                                     mockLogger.Object);

            var result = await controller.EditAssignment(1, editDto) as BadRequestObjectResult;

            Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal(ErrorCode.ASSET_IS_NOT_AVAILABLE, result.Value);
        }

        [Fact]
        public async Task EditAssignment_With_Edit_Failed_Return_BadRequest_With_ErrorCode()
        {
            var mockAssignmentRepository = new Mock<IAssignmentRepository>();
            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();
            var mockMapper = new Mock<IMapper>();

            var editDto = new CreateAssignmentDTO
            {
                AssetId = 2,
                AssignedDate = DateTime.Now,
                UserId = 2,
                Note = "Test edit"
            };

            var assignment = new Assignment
            {
                AssetId = 1,
                AssignedToId = 1,
                AssignedById = 1,
                Note = "unit test",
                AssignedState = AssignmentStateEnums.Waiting

            };

            var user = new User
            {
                Id = 2,
                UserName = "userTest2"
            };

            var asset = new Asset
            {
                Id = 2,
                StateID = 2
            };

            var updateAssignment = new Assignment
            {
                AssetId = editDto.AssetId,
                AssignedDate = editDto.AssignedDate,
                AssignedToId = editDto.UserId,
                Note = editDto.Note,
                AssignedById = assignment.AssignedById,
                AssignedState = AssignmentStateEnums.Waiting
            };

            mockAssignmentRepository.Setup(a => a.GetAssignmentAsync(It.IsAny<int>())).Returns(Task.FromResult(assignment));

            mockUserManager.Setup(u => u.FindByIdAsync(It.IsAny<string>())).Returns(Task.FromResult(user));

            mockAssetRepository.Setup(a => a.GetAssetByIdAsync(It.IsAny<int>())).Returns(Task.FromResult<Asset?>(asset));

            mockAssetRepository.Setup(a => a.SetAssetAvailable(It.IsAny<Asset>())).Returns(Task.CompletedTask);

            mockMapper.Setup(m => m.Map(It.IsAny<CreateAssignmentDTO>(), It.IsAny<Assignment>())).Returns(updateAssignment);

            mockAssignmentRepository.Setup(a => a.UpdateAssignment(It.IsAny<Asset>(), It.IsAny<User>(), It.IsAny<Assignment>())).Throws(new Exception());

            var controller = new AssignmentController(mockAssignmentRepository.Object,
                                                     mockAssetRepository.Object,
                                                     mockUserManager.Object,
                                                     mockMapper.Object,
                                                     mockLogger.Object);

            var result = await controller.EditAssignment(1, editDto) as BadRequestObjectResult;

            Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal(ErrorCode.EDIT_ASSIGNMENT_FAILED, result.Value);
        }

        [Fact]
        public async Task DeleteAssignmet_WhenSuccess_ReturnOkObject()
        {
            //Arrange
            Assignment assignmentDummy = new Assignment() { Id = 1,AssetId=1,AssignedState=AssignmentStateEnums.Waiting };
            var id = 1;
            var expectedMessage = "Assignment deleted";

            var assignmentRepositoryMock = new Mock<IAssignmentRepository>();
            assignmentRepositoryMock.Setup(x => x.DeleteAssignment(id)).Returns(Task.FromResult(assignmentDummy));
            assignmentRepositoryMock.Setup(x => x.GetAssignmentAsync(id)).Returns(Task.FromResult(assignmentDummy));

            var mapperMock = new Mock<IMapper>();
            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();

            var controller = new AssignmentController(assignmentRepositoryMock.Object, mockAssetRepository.Object, mockUserManager.Object, mapperMock.Object, mockLogger.Object);

            // Act
            var result = (await controller.DeleteAssignment(id)) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedMessage, result.Value.ToString());
        }

        [Fact]
        public async Task DeleteAssignmet_WhenAssignmentNotFound_ReturnNotFoundObject()
        {
            //Arrange
            Assignment assignmentDummy = new Assignment() { Id = 1, AssetId = 1, AssignedState = AssignmentStateEnums.Waiting };
            var id = 1;
            var expectedMessage = "Assignment not found";

            var assignmentRepositoryMock = new Mock<IAssignmentRepository>();
            assignmentRepositoryMock.Setup(x => x.DeleteAssignment(id)).Returns(Task.FromResult(assignmentDummy));
            assignmentRepositoryMock.Setup(x => x.GetAssignmentAsync(id));

            var mapperMock = new Mock<IMapper>();
            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();

            var controller = new AssignmentController(assignmentRepositoryMock.Object, mockAssetRepository.Object, mockUserManager.Object, mapperMock.Object, mockLogger.Object);

            // Act
            var result = (await controller.DeleteAssignment(id)) as NotFoundObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedMessage, result.Value.ToString());
        }

        [Fact]
        public async Task DeleteAssignmet_WhenAssignmentStateNotCorrect_ReturnBadRequestObject()
        {
            //Arrange
            Assignment assignmentDummy = new Assignment() { Id = 1, AssetId = 1, AssignedState = AssignmentStateEnums.Accepted };
            var id = 1;
            var expectedMessage = "Assignment state not correct";

            var assignmentRepositoryMock = new Mock<IAssignmentRepository>();
            assignmentRepositoryMock.Setup(x => x.DeleteAssignment(id)).Returns(Task.FromResult(assignmentDummy));
            assignmentRepositoryMock.Setup(x => x.GetAssignmentAsync(id)).Returns(Task.FromResult(assignmentDummy));

            var mapperMock = new Mock<IMapper>();
            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();

            var controller = new AssignmentController(assignmentRepositoryMock.Object, mockAssetRepository.Object, mockUserManager.Object, mapperMock.Object, mockLogger.Object);

            // Act
            var result = (await controller.DeleteAssignment(id)) as BadRequestObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedMessage, result.Value.ToString());
        }

        [Fact]
        public async Task DeleteAssignmet_WhenThrowErrors_ReturnBadRequestObject()
        {
            //Arrange
            Assignment assignmentDummy = new Assignment() { Id = 1, AssetId = 1, AssignedState = AssignmentStateEnums.Accepted };
            var id = 1;
            var expectedMessage = "Something went wrong";

            var assignmentRepositoryMock = new Mock<IAssignmentRepository>();
            assignmentRepositoryMock.Setup(x => x.DeleteAssignment(id)).Throws(new Exception());
            assignmentRepositoryMock.Setup(x => x.GetAssignmentAsync(id)).Throws(new Exception());

            var mapperMock = new Mock<IMapper>();
            var mockLogger = new Mock<ILogger<AssignmentController>>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockUserManager = new Mock<FakeUserManager>();

            var controller = new AssignmentController(assignmentRepositoryMock.Object, mockAssetRepository.Object, mockUserManager.Object, mapperMock.Object, mockLogger.Object);

            // Act
            var result = (await controller.DeleteAssignment(id)) as BadRequestObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedMessage, result.Value.ToString());
        }
    }
}