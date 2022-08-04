using AssetManagement.Domain.Model;
using AssetManagement.Application.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using AssetManagement.Contracts.AssetDTO;
using AssetManagement.Contracts.Constant;
using AssetManagement.Data.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace AssetManagement.Application.Tests
{
    public class AssetControllerTests
    {
        private User GetUser()
        {
            return new User
            {
                Id = 0,
                UserName = "Admin",
                NormalizedUserName = RoleConstant.Admin,
                IsDisabled = false
            };
        }

        private IList<string> GetUserRole()
        {
            var result = new List<string>();
            result.Add(RoleConstant.Admin);
            return result;
        }

        [Fact]
        public async Task CreateNewAsset_Success()
        {
            //Arrange
            var asset = new Asset
            {
                Id = 1,
                Code = "LA000001",
                Name = "Laptop HP Probook 450 G1",
                Specification = "Dummy Spec 1",
                InstalledDate = DateTime.Now,
                CategoryID = 1,
                StateID = 2,
                LocationID = 1
            };

            var assetDTO = new AssetDTO
            {
                Code = "LA000001",
                Name = "Laptop HP Probook 450 G1",
                Category = "Laptop",
                State = "Available",
                Location = "HCM"
            };

            var newAsset = new CreateAssetRequest
            {
                AssetName = "Laptop XXX",
                Specification = "Haha haha",
                CategoryId = 1,
                AssetStateId = 2,
                InstalledDate = new DateTime()
            };

            var expectedResult = new ApiResult<string>(null)
            {
                Message = "Create new asset successfully!",
                StatusCode = 200,
            };

            var assetRepositoryMock = new Mock<IAssetRepository>();
            assetRepositoryMock.Setup(x => x.CreateAsync(It.IsAny<CreateAssetRequest>())).Returns(Task.FromResult(expectedResult));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<AssetDTO>(asset)).Returns(assetDTO);

            var mockUserManager = new Mock<FakeUserManager>();
            mockUserManager.Setup(u => u.FindByNameAsync(It.IsAny<string>())).Returns(Task.FromResult(GetUser()));
            mockUserManager.Setup(u => u.CheckPasswordAsync(It.IsAny<User>(), It.IsAny<string>())).Returns(Task.FromResult(true));
            mockUserManager.Setup(u => u.GetRolesAsync(It.IsAny<User>())).Returns(Task.FromResult(GetUserRole()));

            var controller = new AssetController(mapperMock.Object, assetRepositoryMock.Object, mockUserManager.Object);

            // Act
            var result = (await controller.CreateAsync(newAsset)) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal("Create new asset successfully!", result.Value.ToString());
            Assert.Equal(200, result.StatusCode);
        }

        [Fact]
        public async Task CreateNewAsset_StateNotAllowed()
        {
            //Arrange
            var asset = new Asset
            {
                Id = 1,
                Code = "LA000001",
                Name = "Laptop HP Probook 450 G1",
                Specification = "Dummy Spec 1",
                InstalledDate = DateTime.Now,
                CategoryID = 1,
                StateID = 2,
                LocationID = 1
            };

            var assetDTO = new AssetDTO
            {
                Code = "LA000001",
                Name = "Laptop HP Probook 450 G1",
                Category = "Laptop",
                State = "Available",
                Location = "HCM"
            };

            var newAsset = new CreateAssetRequest
            {
                AssetName = "Laptop XXX",
                Specification = "Haha haha",
                CategoryId = 1,
                AssetStateId = 2,
                InstalledDate = new DateTime()
            };

            var expectedResult = new ApiResult<string>(null)
            {
                Message = "This asset state is not allowed!",
                StatusCode = 400,
            };

            var assetRepositoryMock = new Mock<IAssetRepository>();
            assetRepositoryMock.Setup(x => x.CreateAsync(It.IsAny<CreateAssetRequest>())).Returns(Task.FromResult(expectedResult));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<AssetDTO>(asset)).Returns(assetDTO);

            var mockUserManager = new Mock<FakeUserManager>();
            mockUserManager.Setup(u => u.FindByNameAsync(It.IsAny<string>())).Returns(Task.FromResult(GetUser()));
            mockUserManager.Setup(u => u.CheckPasswordAsync(It.IsAny<User>(), It.IsAny<string>())).Returns(Task.FromResult(true));
            mockUserManager.Setup(u => u.GetRolesAsync(It.IsAny<User>())).Returns(Task.FromResult(GetUserRole()));

            var controller = new AssetController(mapperMock.Object, assetRepositoryMock.Object, mockUserManager.Object);

            // Act
            var result = (await controller.CreateAsync(newAsset)) as BadRequestObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal("This asset state is not allowed!", result.Value.ToString());
            Assert.Equal(400, result.StatusCode);
        }

        [Fact]
        public async Task CreateNewAsset_CategoryNotExisted()
        {
            //Arrange
            var asset = new Asset
            {
                Id = 1,
                Code = "LA000001",
                Name = "Laptop HP Probook 450 G1",
                Specification = "Dummy Spec 1",
                InstalledDate = DateTime.Now,
                CategoryID = 1,
                StateID = 2,
                LocationID = 1
            };

            var assetDTO = new AssetDTO
            {
                Code = "LA000001",
                Name = "Laptop HP Probook 450 G1",
                Category = "Laptop",
                State = "Available",
                Location = "HCM"
            };

            var newAsset = new CreateAssetRequest
            {
                AssetName = "Laptop XXX",
                Specification = "Haha haha",
                CategoryId = 1,
                AssetStateId = 2,
                InstalledDate = new DateTime()
            };

            var expectedResult = new ApiResult<string>(null)
            {
                Message = "Category does not exist!",
                StatusCode = 400,
            };

            var assetRepositoryMock = new Mock<IAssetRepository>();
            assetRepositoryMock.Setup(x => x.CreateAsync(It.IsAny<CreateAssetRequest>())).Returns(Task.FromResult(expectedResult));

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(s => s.Map<AssetDTO>(asset)).Returns(assetDTO);

            var mockUserManager = new Mock<FakeUserManager>();
            mockUserManager.Setup(u => u.FindByNameAsync(It.IsAny<string>())).Returns(Task.FromResult(GetUser()));
            mockUserManager.Setup(u => u.CheckPasswordAsync(It.IsAny<User>(), It.IsAny<string>())).Returns(Task.FromResult(true));
            mockUserManager.Setup(u => u.GetRolesAsync(It.IsAny<User>())).Returns(Task.FromResult(GetUserRole()));

            var controller = new AssetController(mapperMock.Object, assetRepositoryMock.Object, mockUserManager.Object);

            // Act
            var result = (await controller.CreateAsync(newAsset)) as BadRequestObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal("Category does not exist!", result.Value.ToString());
            Assert.Equal(400, result.StatusCode);
        }
    }
}