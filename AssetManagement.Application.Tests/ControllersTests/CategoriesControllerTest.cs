using AssetManagement.Application.Controllers;
using AssetManagement.Contracts.CategoryDTO;
using AssetManagement.Contracts.Constant;
using AssetManagement.Data.Repositories;
using AssetManagement.Domain.Model;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Application.Tests.ControllersTests
{
    public class CategoriesControllerTest
    {
        [Fact]
        public async Task CreateNewCategory_Success()
        {
            //Arrange
            var asset = new Category
            {
                Id = 1,
                Name = "Laptop",
                Prefix = "LA"
            };

            var categoryDTO = new CategoryViewModel
            {
                Id = 1,
                Name = "Laptop",
                Prefix = "LA"
            };

            var newCategory = new CreateCategoryRequest
            {
                Name = "Mouse",
                Prefix = "MS"
            };

            var expectedResult = new ApiResult<string>(null)
            {
                Message = "Create new category successfully!",
                StatusCode = 200,
            };

            var categoryRepositoryMock = new Mock<ICategoryRepository>();
            categoryRepositoryMock.Setup(x => x.CreateAsync(It.IsAny<CreateCategoryRequest>())).Returns(Task.FromResult(expectedResult));


            var controller = new CategoriesController(categoryRepositoryMock.Object);

            // Act
            var result = (await controller.CreateAsync(newCategory)) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal("Create new category successfully!", result.Value.ToString());
            Assert.Equal(200, result.StatusCode);
        }

        [Fact]
        public async Task CreateNewCategory_PrefixExist()
        {
            //Arrange
            var asset = new Category
            {
                Id = 1,
                Name = "Laptop",
                Prefix = "LA"
            };

            var categoryDTO = new CategoryViewModel
            {
                Id = 1,
                Name = "Laptop",
                Prefix = "LA"
            };

            var newCategory = new CreateCategoryRequest
            {
                Name = "Mouse",
                Prefix = "MS"
            };

            var expectedResult = new ApiResult<string>(null)
            {
                Message = "Category prefix existed!",
                StatusCode = 400,
            };

            var categoryRepositoryMock = new Mock<ICategoryRepository>();
            categoryRepositoryMock.Setup(x => x.CreateAsync(It.IsAny<CreateCategoryRequest>())).Returns(Task.FromResult(expectedResult));


            var controller = new CategoriesController(categoryRepositoryMock.Object);

            // Act
            var result = (await controller.CreateAsync(newCategory)) as BadRequestObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal("Category prefix existed!", result.Value.ToString());
            Assert.Equal(400, result.StatusCode);
        }

        [Fact]
        public async Task CreateNewCategory_NameExist()
        {
            //Arrange
            var asset = new Category
            {
                Id = 1,
                Name = "Laptop",
                Prefix = "LA"
            };

            var categoryDTO = new CategoryViewModel
            {
                Id = 1,
                Name = "Laptop",
                Prefix = "LA"
            };

            var newCategory = new CreateCategoryRequest
            {
                Name = "Mouse",
                Prefix = "MS"
            };

            var expectedResult = new ApiResult<string>(null)
            {
                Message = "Category name existed!",
                StatusCode = 400,
            };

            var categoryRepositoryMock = new Mock<ICategoryRepository>();
            categoryRepositoryMock.Setup(x => x.CreateAsync(It.IsAny<CreateCategoryRequest>())).Returns(Task.FromResult(expectedResult));


            var controller = new CategoriesController(categoryRepositoryMock.Object);

            // Act
            var result = (await controller.CreateAsync(newCategory)) as BadRequestObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal("Category name existed!", result.Value.ToString());
            Assert.Equal(400, result.StatusCode);
        }

        [Fact]
        public async Task CreateNewCategory_NameOrPrefixEmpty()
        {
            //Arrange
            var newCategory = new CreateCategoryRequest
            {
                Name = "",
                Prefix = ""
            };

            var expectedResult = new ApiResult<string>(null)
            {
                Message = "Category name or prefix is empty!",
                StatusCode = 400,
            };

            var categoryRepositoryMock = new Mock<ICategoryRepository>();
            categoryRepositoryMock.Setup(x => x.CreateAsync(It.IsAny<CreateCategoryRequest>())).Returns(Task.FromResult(expectedResult));


            var controller = new CategoriesController(categoryRepositoryMock.Object);

            // Act
            var result = (await controller.CreateAsync(newCategory)) as BadRequestObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal("Category name or prefix is empty!", result.Value.ToString());
            Assert.Equal(400, result.StatusCode);
        }
    }
}
