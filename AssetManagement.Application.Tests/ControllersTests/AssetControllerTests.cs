using AssetManagement.Application.Application.Interfaces;
using AssetManagement.Domain.Model;
using AssetManagement.Application.Controllers;
using AssetManagement.Contracts.ViewModels;
using Microsoft.AspNetCore.Mvc;

using Moq;
using AssetManagement.Data;
using AutoMapper;
using AssetManagement.Contracts.AssetDTO;
using System.Security.Claims;
using System.Security.Principal;
using Microsoft.AspNetCore.Http;
using AssetManagement.Contracts;

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
        [Fact]
        public async Task Test_Asset_GetAssetList_Return_Asset_List_With_Pagination()
        {
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            var mockMapper = new Mock<IMapper>();
            var mockUserManager = new Mock<FakeUserManager>();

            var admin = new User()
            {
                Id = 1,
                UserName = "Admin",
                LocationId = 1,
            };

            var listAsset = GenerateAssetList(20);

            var listAssetDto = ConvertDTO(listAsset);

            AssetParameters parameters = new() { Searching = "la", Category = new() { 1 } };

            mockUserManager.Setup(u => u.FindByNameAsync(It.IsAny<string>())).Returns(Task.FromResult(admin));

            mockUnitOfWork.Setup(u => u.Assets.GetAllAsync()).Returns(Task.FromResult(listAsset.AsEnumerable()));

            mockMapper.Setup(m => m.Map<List<AssetDTO>>(It.IsAny<List<Asset>>())).Returns(listAssetDto.Skip((parameters.PageNumber - 1) * parameters.PageSize).Take(parameters.PageSize).ToList());

            var claimUser = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Name, "Admin"),
                new Claim(ClaimTypes.NameIdentifier, "1"),
            }, "mock"));

            var identity = new GenericIdentity(ClaimTypes.Name, "AdminHCM");

            identity.AddClaim(new Claim(ClaimTypes.Role, "Admin"));

            var httpContext = new DefaultHttpContext()
            {
                User = claimUser,
            };

            var controllerContext = new ControllerContext()
            {
                HttpContext = httpContext,
            };

            AssetController controller = new(mockUnitOfWork.Object, mockMapper.Object, mockUserManager.Object) { ControllerContext = controllerContext };

            var result = await controller.GetAllAsync(parameters) as OkObjectResult;

            Assert.IsType<OkObjectResult>(result);

            Assert.IsType<PageList<Asset, AssetDTO>>(result.Value);
        }

        private List<Asset> GenerateAssetList(int number)
        {
            var assetList = new List<Asset>();
            for (int i = 1; i <= number; i++)
            {
                assetList.Add(new Asset()
                {
                    Id = i,
                    Code =  $"LA{i.ToString().PadLeft(6,'0')}",
                    Name = "Laptop HP Probook 450 G1",
                    Specification = "Dummy Spec 1",
                    InstalledDate = DateTime.Now,
                    CategoryID = 1,
                    Category = new Category() { Id = 1, Name = "Laptop"},
                    StateID = 2,
                    State = new State() { Id = 2, Name = "Available"},
                    LocationID = 1,
                    Location = new Location() { Id = 1, LocationName = "HCM"},
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                });
            }
            return assetList;
        }

        private List<AssetDTO> ConvertDTO(List<Asset> assets)
        {
            var assetListDto = new List<AssetDTO>();
            foreach (var asset in assets)
            {
                assetListDto.Add(new()
                {
                    Name =asset.Name,
                    Category = asset.Category.Name,
                    State = asset.State.Name,
                    Code  = asset.Code,
                    Location = asset.Location.LocationName
                });
            }
            return assetListDto;
        }
    }
}