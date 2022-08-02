using AssetManagement.Application.Application.Interfaces;
using AssetManagement.Domain.Model;
using AssetManagement.Application.Controllers;
using AssetManagement.Contracts.ViewModels;
using Microsoft.AspNetCore.Mvc;

using Moq;

namespace AssetManagement.Application.Tests
{
    public class AssetControllerTests
    {
        /*[Fact]
        public async void CanGetAllByCurrentAdminLocationAsync_NotFound()
        {
            // Arrange
            Mock<IAssetService> mock = new();
            mock.Setup(assetService => assetService.GetAllByCurrentAdminLocationAsync())
                .ReturnsAsync(new List<Asset>());

            AssetController controller = new(mock.Object, MockData.mapper);

            // Act
            var result = (await controller.GetAllByCurrentAdminLocationAsync());

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async void CanGetAllByCurrentAdminLocationAsync_Ok()
        {
            // Arrange
            Mock<IAssetService> mock = new();
            mock.Setup(assetService => assetService.GetAllByCurrentAdminLocationAsync())
                .ReturnsAsync(MockData.assets);

            AssetController controller = new(mock.Object, MockData.mapper);

            // Act
            var actionResult = (await controller.GetAllByCurrentAdminLocationAsync());

            // Assert
            Assert.NotNull(actionResult);
            Assert.IsType<OkObjectResult>(actionResult);

            var resultValue = (actionResult as OkObjectResult)?.Value as List<AssetDTO>;
            Assert.NotNull(resultValue);
            
            var assertValue = MockData.mapper.Map<List<AssetDTO>>(MockData.assets);
            Assert.True(Enumerable.SequenceEqual(resultValue ?? new List<AssetDTO>(), assertValue));
        }

        [Fact]
        public async void CanGetAllAsync_NotFound()
        {
            // Arrange
            Mock<IAssetService> mock = new();
            mock.Setup(assetService => assetService.GetAllAsync())
                .ReturnsAsync(new List<Asset>());

            AssetController controller = new(mock.Object, MockData.mapper);

            // Act
            var result = (await controller.GetAllAsync());

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async void CanGetAllAsync_Ok()
        {
            // Arrange
            Mock<IAssetService> mock = new();
            mock.Setup(assetService => assetService.GetAllAsync())
                .ReturnsAsync(MockData.assets);

            AssetController controller = new(mock.Object, MockData.mapper);

            // Act
            var actionResult = (await controller.GetAllAsync());

            // Assert
            Assert.NotNull(actionResult);
            Assert.IsType<OkObjectResult>(actionResult);

            var resultValue = (actionResult as OkObjectResult)?.Value as List<AssetDTO>;
            Assert.NotNull(resultValue);

            var assertValue = MockData.mapper.Map<List<AssetDTO>>(MockData.assets);
            Assert.True(Enumerable.SequenceEqual(resultValue ?? new List<AssetDTO>(), assertValue));
        }

        [Fact]
        public async void CanGetByAssetCode_NotFound()
        {
            // Arrange
            Mock<IAssetService> mock = new();
            mock.Setup(assetService => assetService.GetByAssetCodeAsync(It.IsAny<string>()))
                .ReturnsAsync((Asset?)null);

            AssetController controller = new(mock.Object, MockData.mapper);

            // Act
            var result = (await controller.GetByAssetCodeAsync(""));

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async void CanGetByAssetCode_Ok()
        {
            // Arrange
            Mock<IAssetService> mock = new();
            mock.Setup(assetService => assetService.GetByAssetCodeAsync(It.IsAny<string>()))
                .ReturnsAsync(MockData.assets[0]);

            AssetController controller = new(mock.Object, MockData.mapper);

            // Act
            var actionResult = (await controller.GetByAssetCodeAsync(""));

            // Assert
            Assert.NotNull(actionResult);
            Assert.IsType<OkObjectResult>(actionResult);

            var resultValue = (actionResult as OkObjectResult)?.Value as AssetDetailDTO;
            Assert.NotNull(resultValue);

            var assertValue = MockData.mapper.Map<AssetDetailDTO>(MockData.assets[0]);
            Assert.Equal(resultValue, assertValue);
        }*/
    }
}