using AssetManagement.Application.Controllers;
using AssetManagement.Contracts.Constant;
using AssetManagement.Contracts.ReturnRequestDTO;
using AssetManagement.Data.Repositories;
using AssetManagement.Domain.Model;
using AssetManagement.Domain.Model.Enums;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Application.Tests.ControllersTests
{
    public class ReturnRequestControllerTest
    {

        #region Get Return request list
        [Fact]
        public async Task GetReturnRequestList_WhenSuccess_ReturnOkObject()
        {
            //Arrange
            var sorting = new ReturnRequestParameters() { Searching = "vinz", State = new List<int>(new int[2] { 1, 2 }), ReturnedDate = new DateTime() }; 

            IEnumerable<ReturnRequest> returnRequestList = GenerateListReturnRequests(10);

            IEnumerable<ReturnRequestDTO> returnRequestListDTO = new List<ReturnRequestDTO>()
            {
                new ReturnRequestDTO{Id=1,AssetCode="LA000001",AssetName="Laptop"},
                new ReturnRequestDTO{Id=1,AssetCode="LA000001",AssetName="Laptop"}
            };

            var assignmentRepositoryMock = new Mock<IReturnRequestRepository>();
            assignmentRepositoryMock.Setup(x => x.GetAsync(sorting.Searching, sorting.ReturnedDate, sorting.State)).Returns(Task.FromResult(returnRequestList));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<IEnumerable<ReturnRequestDTO>>(returnRequestList)).Returns(returnRequestListDTO);

            var controller = new ReturnRequestController(assignmentRepositoryMock.Object, mapperMock.Object);

            // Act
            var result = (await controller.GetReturnRequests(sorting)) as OkObjectResult;

            // Assert
            Assert.NotNull(result);

            var data = result.Value as IEnumerable<ReturnRequestDTO>;
            Assert.NotNull(data);
            Assert.Equal(returnRequestListDTO, data);
        }

        [Fact]
        public async Task GetReturnRequestList_WhenNotFoundReturnRequests_ReturnNotFoundObject()
        {
            //Arrange
            var sorting = new ReturnRequestParameters() { Searching = "vinz", State = new List<int>(new int[2] { 1, 2 }), ReturnedDate = new DateTime() };

            IEnumerable<ReturnRequest> returnRequestList = GenerateListReturnRequests(10);

            IEnumerable<ReturnRequestDTO> returnRequestListDTO = new List<ReturnRequestDTO>()
            {
                new ReturnRequestDTO{Id=1,AssetCode="LA000001",AssetName="Laptop"},
                new ReturnRequestDTO{Id=1,AssetCode="LA000001",AssetName="Laptop"}
            };

            var expectedMessage = "Return Request List Empty";

            var assignmentRepositoryMock = new Mock<IReturnRequestRepository>();
            assignmentRepositoryMock.Setup(x => x.GetAsync(sorting.Searching, sorting.ReturnedDate, sorting.State));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<IEnumerable<ReturnRequestDTO>>(returnRequestList)).Returns(returnRequestListDTO);

            var controller = new ReturnRequestController(assignmentRepositoryMock.Object, mapperMock.Object);

            // Act
            var result = (await controller.GetReturnRequests(sorting)) as NotFoundObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedMessage, result.Value.ToString());
        }


        [Fact]
        public async Task GetReturnRequestList_WhenThrowErrors_ReturnBadRequestObject()
        {
            //Arrange
            var sorting = new ReturnRequestParameters() { Searching = "vinz", State = new List<int>(new int[2] { 1, 2 }), ReturnedDate = new DateTime() };

            IEnumerable<ReturnRequest> returnRequestList = GenerateListReturnRequests(10).AsEnumerable();

            IEnumerable<ReturnRequestDTO> returnRequestListDTO = new List<ReturnRequestDTO>()
            {
                new ReturnRequestDTO{Id=1,AssetCode="LA000001",AssetName="Laptop"},
                new ReturnRequestDTO{Id=1,AssetCode="LA000001",AssetName="Laptop"}
            };

            var expectedMessage = "Something went wrong";

            var assignmentRepositoryMock = new Mock<IReturnRequestRepository>();
            assignmentRepositoryMock.Setup(x => x.GetAsync(sorting.Searching, sorting.ReturnedDate, sorting.State)).Throws(new Exception(expectedMessage));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<IEnumerable<ReturnRequestDTO>>(returnRequestList)).Returns(returnRequestListDTO);

            var controller = new ReturnRequestController(assignmentRepositoryMock.Object, mapperMock.Object);

            // Act
            var result = (await controller.GetReturnRequests(sorting)) as BadRequestObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedMessage, result.Value.ToString());
        }
        #endregion

        #region Get Return request by Id
        [Fact]
        public async Task GetReturnRequestListById_WhenSuccess_ReturnOkObject()
        {
            //Arrange
            var id = 1;
            ReturnRequest returnRequest = new ReturnRequest() { Id = 1,RequestedById=4 };
            ReturnRequestDTO returnRequestDTO = new ReturnRequestDTO() { Id = 1, RequestedBy = "vinhbx" };

            var assignmentRepositoryMock = new Mock<IReturnRequestRepository>();
            assignmentRepositoryMock.Setup(x => x.GetAsyncById(id)).Returns(Task.FromResult(returnRequest));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<ReturnRequestDTO>(returnRequest)).Returns(returnRequestDTO);

            var controller = new ReturnRequestController(assignmentRepositoryMock.Object, mapperMock.Object);

            // Act
            var result = (await controller.GetReturnRequestById(id)) as OkObjectResult;

            // Assert
            Assert.NotNull(result);

            var data = result.Value as ReturnRequestDTO;
            Assert.NotNull(data);
            Assert.Equal(returnRequestDTO, data);

        }

        [Fact]
        public async Task GetReturnRequestListById_WhenNotFoundReturnRequests_ReturnNotFoundObject()
        {
            //Arrange
            var id = 1;
            ReturnRequest returnRequest = new ReturnRequest() { Id = 1, RequestedById = 4 };
            ReturnRequestDTO returnRequestDTO = new ReturnRequestDTO() { Id = 1, RequestedBy = "vinhbx" };
            var expectedMessage = "Return request not found";

            var assignmentRepositoryMock = new Mock<IReturnRequestRepository>();
            assignmentRepositoryMock.Setup(x => x.GetAsyncById(id));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<ReturnRequestDTO>(returnRequest)).Returns(returnRequestDTO);

            var controller = new ReturnRequestController(assignmentRepositoryMock.Object, mapperMock.Object);

            // Act
            var result = (await controller.GetReturnRequestById(id)) as NotFoundObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedMessage, result.Value.ToString());

        }

        [Fact]
        public async Task GetReturnRequestListById_WhenThrowErrors_ReturnBadRequestObject()
        {
            //Arrange
            var id = 1;
            ReturnRequest returnRequest = new ReturnRequest() { Id = 1, RequestedById = 4 };
            ReturnRequestDTO returnRequestDTO = new ReturnRequestDTO() { Id = 1, RequestedBy = "vinhbx" };
            var expectedMessage = "Something went wrong";

            var assignmentRepositoryMock = new Mock<IReturnRequestRepository>();
            assignmentRepositoryMock.Setup(x => x.GetAsyncById(id)).Throws(new Exception(expectedMessage));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<ReturnRequestDTO>(returnRequest)).Returns(returnRequestDTO);

            var controller = new ReturnRequestController(assignmentRepositoryMock.Object, mapperMock.Object);

            // Act
            var result = (await controller.GetReturnRequestById(id)) as BadRequestObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedMessage, result.Value.ToString());

        }

        #endregion

        #region Update Return request state
        [Fact]
        public async Task UpdateReturnRequestState_WhenSuccess_ReturnOkObjectResult()
        {
            //Arrange
            var id = 1;
            var state = true;
            ReturnRequest returnRequest = new ReturnRequest() { Id = 1, RequestedById = 4 };
            ReturnRequestDTO returnRequestDTO = new ReturnRequestDTO() { Id = 1, RequestedBy = "vinhbx" };
            var expectedMessage = "Return request state updated";


            var assignmentRepositoryMock = new Mock<IReturnRequestRepository>();
            assignmentRepositoryMock.Setup(x => x.GetAsyncById(id)).Returns(Task.FromResult(returnRequest));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<ReturnRequestDTO>(returnRequest)).Returns(returnRequestDTO);

            var controller = new ReturnRequestController(assignmentRepositoryMock.Object, mapperMock.Object);

            // Act
            var result = (await controller.UpdateReturnRequestState(id,state)) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedMessage, result.Value.ToString());
        }

        [Fact]
        public async Task UpdateReturnRequestState_WhenNotFoundReturnRequests_ReturnNotFoundObject()
        {
            //Arrange
            var id = 1;
            var state = true;
            ReturnRequest returnRequest = new ReturnRequest() { Id = 1, RequestedById = 4 };
            ReturnRequestDTO returnRequestDTO = new ReturnRequestDTO() { Id = 1, RequestedBy = "vinhbx" };
            var expectedMessage = "Return request not found";


            var assignmentRepositoryMock = new Mock<IReturnRequestRepository>();
            assignmentRepositoryMock.Setup(x => x.GetAsyncById(id));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<ReturnRequestDTO>(returnRequest)).Returns(returnRequestDTO);

            var controller = new ReturnRequestController(assignmentRepositoryMock.Object, mapperMock.Object);

            // Act
            var result = (await controller.UpdateReturnRequestState(id, state)) as NotFoundObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedMessage, result.Value.ToString());
        }

        [Fact]
        public async Task UpdateReturnRequestState_WhenReturnRequestsUpdatedPreviously_ReturnBadRequestObject()
        {
            //Arrange
            var id = 1;
            var state = true;
            ReturnRequest returnRequest = new ReturnRequest() { Id = 1, RequestedById = 4 ,State=ReturnRequestStateEnums.Completed};
            ReturnRequestDTO returnRequestDTO = new ReturnRequestDTO() { Id = 1, RequestedBy = "vinhbx" };
            var expectedMessage = "Return request already accepted";


            var assignmentRepositoryMock = new Mock<IReturnRequestRepository>();
            assignmentRepositoryMock.Setup(x => x.GetAsyncById(id)).Returns(Task.FromResult(returnRequest));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<ReturnRequestDTO>(returnRequest)).Returns(returnRequestDTO);

            var controller = new ReturnRequestController(assignmentRepositoryMock.Object, mapperMock.Object);

            // Act
            var result = (await controller.UpdateReturnRequestState(id, state)) as BadRequestObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedMessage, result.Value.ToString());
        }

        [Fact]
        public async Task UpdateReturnRequestState_WhenThrowErrors_ReturnBadRequestObject()
        {
            //Arrange
            var id = 1;
            var state = true;
            ReturnRequest returnRequest = new ReturnRequest() { Id = 1, RequestedById = 4 };
            ReturnRequestDTO returnRequestDTO = new ReturnRequestDTO() { Id = 1, RequestedBy = "vinhbx" };
            var expectedMessage = "Something went wrong";


            var assignmentRepositoryMock = new Mock<IReturnRequestRepository>();
            assignmentRepositoryMock.Setup(x => x.GetAsyncById(id)).Throws(new Exception(expectedMessage));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<ReturnRequestDTO>(returnRequest)).Returns(returnRequestDTO);

            var controller = new ReturnRequestController(assignmentRepositoryMock.Object, mapperMock.Object);

            // Act
            var result = (await controller.UpdateReturnRequestState(id, state)) as BadRequestObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedMessage, result.Value.ToString());
        }
        #endregion

        private List<ReturnRequest> GenerateListReturnRequests(int number)
        {
            var list = new List<ReturnRequest>();
            for (int i = 1; i <= number; i++)
            {
                list.Add(new ReturnRequest
                {
                    Id = i,
                    ReturnedDate = DateTime.Now,
                    State = ReturnRequestStateEnums.Completed,
                    Assignment = new Assignment { Id = 1 ,Asset = new Asset() { Id=1,Code="LA00001"},AssignedTo=new User() { Id=1} },
                });
                
            }
            return list;
        }

        [Fact]
        public async Task CreateReturnRequest_Ok()
        {
            //Arrange
            IEnumerable<ReturnRequest> returnRequestList = GenerateListReturnRequests(10).AsEnumerable();

            IEnumerable<ReturnRequestDTO> returnRequestListDTO = new List<ReturnRequestDTO>()
            {
                new ReturnRequestDTO{Id=1,AssetCode="LA000001",AssetName="Laptop"},
                new ReturnRequestDTO{Id=1,AssetCode="LA000001",AssetName="Laptop"}
            };

            var expectedResult = new ApiResult<bool>(true)
            {
                StatusCode = 200,
                Message = "Create new return request successfully!"
            };

            var assignmentRepositoryMock = new Mock<IReturnRequestRepository>();
            assignmentRepositoryMock.Setup(x => x.CreateAsync(It.IsAny<CreateReturnRequestDTO>())).Returns(Task.FromResult(expectedResult));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<IEnumerable<ReturnRequestDTO>>(returnRequestList)).Returns(returnRequestListDTO);

            var controller = new ReturnRequestController(assignmentRepositoryMock.Object, mapperMock.Object);

            //Act
            var result = (await controller.CreateReturnRequest(new CreateReturnRequestDTO())) as OkObjectResult;

            //Assert
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal("Create new return request successfully!", result.Value.ToString());
            Assert.Equal(200, result.StatusCode);
        }

        [Fact]
        public async Task CreateReturnRequest_BadRequest()
        {
            //Arrange
            IEnumerable<ReturnRequest> returnRequestList = GenerateListReturnRequests(10).AsEnumerable();

            IEnumerable<ReturnRequestDTO> returnRequestListDTO = new List<ReturnRequestDTO>()
            {
                new ReturnRequestDTO{Id=1,AssetCode="LA000001",AssetName="Laptop"},
                new ReturnRequestDTO{Id=1,AssetCode="LA000001",AssetName="Laptop"}
            };

            var expectedResult = new ApiResult<bool>(true)
            {
                StatusCode = 400,
                Message = "Create new return request failly!"
            };

            var assignmentRepositoryMock = new Mock<IReturnRequestRepository>();
            assignmentRepositoryMock.Setup(x => x.CreateAsync(It.IsAny<CreateReturnRequestDTO>())).Returns(Task.FromResult(expectedResult));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<IEnumerable<ReturnRequestDTO>>(returnRequestList)).Returns(returnRequestListDTO);

            var controller = new ReturnRequestController(assignmentRepositoryMock.Object, mapperMock.Object);

            //Act
            var result = (await controller.CreateReturnRequest(new CreateReturnRequestDTO())) as BadRequestObjectResult;

            //Assert
            Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal("Create new return request failly!", result.Value.ToString());
            Assert.Equal(400, result.StatusCode);
        }
    }
}