using AssetManagement.Application.Controllers;
using AssetManagement.Contracts.AssignmentDTO;
using AssetManagement.Data.Repositories;
using AssetManagement.Domain.Model;
using AssetManagement.Domain.Model.Enums;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Moq;


namespace AssetManagement.Application.Tests.ControllersTests
{
    public class AssignmentControllerTest
    {
        [Fact]
        public async Task GetAssignmentList_WhenSuccess_ReturnOkObject()
        {
            //Arrange
            var sorting = new AssignmentParameters() { Searching = "vinz", State = new List<int>(new int[2] { 1,2 }), AssignDate = new DateTime() }; ;

            IEnumerable<Assignment> assignmentList = new List<Assignment>()
            {
                new Assignment{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignTo="vinz",AssignBy="vu",AssignDate=new DateTime(),AssignmentState=AssignmentStateEnums.Accepted},
                new Assignment{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignTo="vinz",AssignBy="vu"}
            };

            IEnumerable<AssignmentDTO> assignmentListDTO = new List<AssignmentDTO>()
            {
                new AssignmentDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignTo="vinz",AssignBy="vu"},
                new AssignmentDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignTo="vinz",AssignBy="vu"}
            };

            var assignmentRepositoryMock = new Mock<IAssignmentRepository>();
            assignmentRepositoryMock.Setup(x => x.GetAsync(sorting.Searching,sorting.AssignDate,sorting.State)).Returns(Task.FromResult(assignmentList));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<IEnumerable<AssignmentDTO>>(assignmentList)).Returns(assignmentListDTO);

            var controller = new AssignmentController(assignmentRepositoryMock.Object, mapperMock.Object);

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

            IEnumerable<Assignment> assignmentList = new List<Assignment>()
            {
                new Assignment{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignTo="vinz",AssignBy="vu",AssignDate=new DateTime(),AssignmentState=AssignmentStateEnums.Accepted},
                new Assignment{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignTo="vinz",AssignBy="vu"}
            };

            IEnumerable<AssignmentDTO> assignmentListDTO = new List<AssignmentDTO>()
            {
                new AssignmentDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignTo="vinz",AssignBy="vu"},
                new AssignmentDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignTo="vinz",AssignBy="vu"}
            };

            var assignmentRepositoryMock = new Mock<IAssignmentRepository>();
            assignmentRepositoryMock.Setup(x => x.GetAsync(sorting.Searching, sorting.AssignDate, sorting.State));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<IEnumerable<AssignmentDTO>>(assignmentList)).Returns(assignmentListDTO);

            var controller = new AssignmentController(assignmentRepositoryMock.Object, mapperMock.Object);

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

            IEnumerable<Assignment> assignmentList = new List<Assignment>()
            {
                new Assignment{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignTo="vinz",AssignBy="vu",AssignDate=new DateTime(),AssignmentState=AssignmentStateEnums.Accepted},
                new Assignment{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignTo="vinz",AssignBy="vu"}
            };

            IEnumerable<AssignmentDTO> assignmentListDTO = new List<AssignmentDTO>()
            {
                new AssignmentDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignTo="vinz",AssignBy="vu"},
                new AssignmentDTO{Id=1,AssetCode="LA000001",AssetName="Laptop",AssignTo="vinz",AssignBy="vu"}
            };

            var assignmentRepositoryMock = new Mock<IAssignmentRepository>();
            assignmentRepositoryMock.Setup(x => x.GetAsync(sorting.Searching, sorting.AssignDate, sorting.State)).Throws(new Exception(expectedMessage));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<IEnumerable<AssignmentDTO>>(assignmentList)).Returns(assignmentListDTO);

            var controller = new AssignmentController(assignmentRepositoryMock.Object, mapperMock.Object);

            // Act
            var result = (await controller.GetAssignments(sorting)) as BadRequestObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedMessage, result.Value.ToString());
        }
    }
}
