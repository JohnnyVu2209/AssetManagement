using AssetManagement.Application.Application.Interfaces;
using AssetManagement.Domain.Model;
using AssetManagement.Application.Controllers;
using Microsoft.AspNetCore.Mvc;

using Moq;

namespace AssetManagement.Application.Tests
{
    public class StateControllerTests
    {
        [Fact]
        public async void CanGetAllAsync_NotFound()
        {
            // Arrange
            Mock<IStateService> mock = new();
            mock.Setup(stateService => stateService.GetAllAsync())
                .ReturnsAsync(new List<State>());

            StateController controller = new(mock.Object, MockData.mapper);

            // Act
            var result = (await controller.GetAllAsync());

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async void CanGetAllAsync_Ok()
        {
            // Arrange
            Mock<IStateService> mock = new();
            mock.Setup(stateService => stateService.GetAllAsync())
                .ReturnsAsync(MockData.states);

            StateController controller = new(mock.Object, MockData.mapper);

            // Act
            var actionResult = (await controller.GetAllAsync());

            // Assert
            Assert.NotNull(actionResult);
            Assert.IsType<OkObjectResult>(actionResult);

            var resultValue = (actionResult as OkObjectResult)?.Value as List<State>;
            Assert.NotNull(resultValue);
            
            var assertValue = MockData.states;
            Assert.True(Enumerable.SequenceEqual(resultValue ?? new List<State>(), assertValue));
        }
    }
}