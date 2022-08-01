using AssetManagement.Application.Application.Interfaces;
using AssetManagement.Domain.Model;
using AssetManagement.Application.Controllers;
using AssetManagement.Contracts.ViewModels;
using Microsoft.AspNetCore.Mvc;

using Moq;

namespace AssetManagement.Application.Tests
{
    public class CategoryControllerTests
    {
        [Fact]
        public async void CanGetAllAsync_NotFound()
        {
            // Arrange
            Mock<ICategoryService> mock = new();
            mock.Setup(categoryService => categoryService.GetAllAsync())
                .ReturnsAsync(new List<Category>());

            CategoryController controller = new(mock.Object, MockData.mapper);

            // Act
            var result = (await controller.GetAllAsync());

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        //[Fact]
        //public async void CanGetAllAsync_Ok()
        //{
        //    // Arrange
        //    Mock<ICategoryService> mock = new();
        //    mock.Setup(categoryService => categoryService.GetAllAsync())
        //        .ReturnsAsync(new List<Category>());

        //    CategoryController controller = new(mock.Object, MockData.mapper);

        //    // Act
        //    var actionResult = (await controller.GetAllAsync());

        //    // Assert
        //    Assert.NotNull(actionResult);
        //    Assert.IsType<OkObjectResult>(actionResult);

        //    var resultValue = (actionResult as OkObjectResult)?.Value as List<Category>;
        //    Assert.NotNull(resultValue);
            
        //    var assertValue = MockData.categories;
        //    Assert.True(Enumerable.SequenceEqual(resultValue ?? new List<Category>(), assertValue));
        //}
    }
}