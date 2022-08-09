using AssetManagement.Application.Controllers;
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
    }
}
