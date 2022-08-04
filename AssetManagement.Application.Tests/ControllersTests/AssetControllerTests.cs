using AssetManagement.Application.Controllers;
using AssetManagement.Contracts;
using AssetManagement.Contracts.AssetDTO;
using AssetManagement.Data.Repositories;
using AssetManagement.Domain.Model;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Security.Claims;
using System.Security.Principal;

namespace AssetManagement.Application.Tests
{
    public class AssetControllerTests
    {
        [Fact]
        public async Task Test_Asset_GetAssetList_Return_Asset_List_With_Pagination()
        {
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockCategoryRepository = new Mock<ICategoryRepository>();
            var mockStateRepository = new Mock<IStateRepository>();
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

            mockAssetRepository.Setup(a => a.GetAssetsByFilter(It.IsAny<int>(), It.IsAny<List<int>>(), It.IsAny<List<int>>(), It.IsAny<string>(), It.IsAny<string>())).Returns(listAsset.AsQueryable());

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

            AssetController controller = new(mockAssetRepository.Object,mockCategoryRepository.Object,mockStateRepository.Object ,mockUserManager.Object,mockMapper.Object) { ControllerContext = controllerContext };

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
                    Code = $"LA{i.ToString().PadLeft(6, '0')}",
                    Name = "Laptop HP Probook 450 G1",
                    Specification = "Dummy Spec 1",
                    InstalledDate = DateTime.Now,
                    CategoryID = 1,
                    Category = new Category() { Id = 1, Name = "Laptop" },
                    StateID = 2,
                    State = new State() { Id = 2, Name = "Available" },
                    LocationID = 1,
                    Location = new Location() { Id = 1, LocationName = "HCM" },
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
                    Name = asset.Name,
                    Category = asset.Category.Name,
                    State = asset.State.Name,
                    Code = asset.Code,
                    Location = asset.Location.LocationName
                });
            }
            return assetListDto;
        }
    }
}