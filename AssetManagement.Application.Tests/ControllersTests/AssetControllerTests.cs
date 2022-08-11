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
using Microsoft.AspNetCore.Identity;
using AssetManagement.Contracts.Constant;
using Microsoft.Extensions.Logging;

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

        #region CreateAsset
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

            var mockCategoryRepository = new Mock<ICategoryRepository>();
            var mockStateRepository = new Mock<IStateRepository>();
            var mockLogger = new Mock<ILogger<AssetController>>();

            AssetController controller = new(assetRepositoryMock.Object,
                                             mockCategoryRepository.Object,
                                             mockStateRepository.Object,
                                             mockUserManager.Object,
                                             mapperMock.Object,
                                             mockLogger.Object);

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

            var mockCategoryRepository = new Mock<ICategoryRepository>();
            var mockStateRepository = new Mock<IStateRepository>();
            var mockLogger = new Mock<ILogger<AssetController>>();

            AssetController controller = new(assetRepositoryMock.Object,
                                             mockCategoryRepository.Object,
                                             mockStateRepository.Object,
                                             mockUserManager.Object,
                                             mapperMock.Object,
                                             mockLogger.Object);

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

            var mockCategoryRepository = new Mock<ICategoryRepository>();
            var mockStateRepository = new Mock<IStateRepository>();
            var mockLogger = new Mock<ILogger<AssetController>>();

            AssetController controller = new(assetRepositoryMock.Object,
                                             mockCategoryRepository.Object,
                                             mockStateRepository.Object,
                                             mockUserManager.Object,
                                             mapperMock.Object,
                                             mockLogger.Object);

            // Act
            var result = (await controller.CreateAsync(newAsset)) as BadRequestObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal("Category does not exist!", result.Value.ToString());
            Assert.Equal(400, result.StatusCode);
        }
        #endregion

        #region Edit Asset
        [Fact]
        public async Task EditAsset_Return_SuccessCode()
        {
            var mockMapper = new Mock<IMapper>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockCategoryRepository = new Mock<ICategoryRepository>();
            var mockStateRepository = new Mock<IStateRepository>();
            var mockUserManager = new Mock<FakeUserManager>();
            var mockLogger = new Mock<ILogger<AssetController>>();

            var editDto = new EditAssetDTO
            {
                Name = "ABC",
                InstalledDate = DateTime.Now,
                Specification = "Testing",
                StateId = 3
            };

            var asset = new Asset
            {
                Id = 1,
                Name = "XYZ",
                Specification = "unit testing",
                StateID = 2,
                InstalledDate = DateTime.Now.AddDays(-10)
            };

            var updateAsset = new Asset
            {
                Id = 1,
                Name = editDto.Name,
                InstalledDate = editDto.InstalledDate,
                Specification = editDto.Specification,
                StateID = editDto.StateId
            };

            mockAssetRepository.Setup(a => a.GetAssetByIdAsync(It.IsAny<int>())).Returns(Task.FromResult<Asset?>(asset));

            mockMapper.Setup(m => m.Map(It.IsAny<EditAssetDTO>(), It.IsAny<Asset>())).Returns(updateAsset);

            mockAssetRepository.Setup(m => m.UpdateAsync(It.IsAny<Asset>())).Returns(Task.FromResult(updateAsset));

            var controller = new AssetController(mockAssetRepository.Object,
                                                 mockCategoryRepository.Object,
                                                 mockStateRepository.Object,
                                                 mockUserManager.Object,
                                                 mockMapper.Object,
                                                 mockLogger.Object);
            var result = await controller.UpdateAsset(1, editDto) as OkObjectResult;

            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(SuccessCode.EDIT_ASSET_SUCCESSFULLY, result.Value);
        }

        [Fact]
        public async Task EditAsset_With_Asset_Is_Null_Return_NotFound_With_ErrorCode()
        {
            var mockMapper = new Mock<IMapper>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockCategoryRepository = new Mock<ICategoryRepository>();
            var mockStateRepository = new Mock<IStateRepository>();
            var mockUserManager = new Mock<FakeUserManager>();
            var mockLogger = new Mock<ILogger<AssetController>>();

            var editDto = new EditAssetDTO
            {
                Name = "ABC",
                InstalledDate = DateTime.Now,
                Specification = "Testing",
                StateId = 3
            };

            mockAssetRepository.Setup(a => a.GetAssetByIdAsync(It.IsAny<int>())).Returns(Task.FromResult<Asset?>(null));

            var controller = new AssetController(mockAssetRepository.Object,
                                                 mockCategoryRepository.Object,
                                                 mockStateRepository.Object,
                                                 mockUserManager.Object,
                                                 mockMapper.Object,
                                                 mockLogger.Object);

            var result = await controller.UpdateAsset(1, editDto) as NotFoundObjectResult;

            Assert.IsType<NotFoundObjectResult>(result);
            Assert.Equal(ErrorCode.ASSET_NOT_FOUND, result.Value);
        }

        [Fact]
        public async Task EditAsset_With_Asset_Is_Not_Available_Return_BadRequest_With_ErrorCode()
        {
            var mockMapper = new Mock<IMapper>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockCategoryRepository = new Mock<ICategoryRepository>();
            var mockStateRepository = new Mock<IStateRepository>();
            var mockUserManager = new Mock<FakeUserManager>();
            var mockLogger = new Mock<ILogger<AssetController>>();

            var editDto = new EditAssetDTO
            {
                Name = "ABC",
                InstalledDate = DateTime.Now,
                Specification = "Testing",
                StateId = 3
            };

            var assignedAsset = new Asset
            {
                Id = 1,
                Name = "XYZ",
                Specification = "unit testing",
                StateID = 1,
                InstalledDate = DateTime.Now.AddDays(-10)
            };

            mockAssetRepository.Setup(a => a.GetAssetByIdAsync(It.IsAny<int>())).Returns(Task.FromResult<Asset?>(assignedAsset));

            var controller = new AssetController(mockAssetRepository.Object,
                                                 mockCategoryRepository.Object,
                                                 mockStateRepository.Object,
                                                 mockUserManager.Object,
                                                 mockMapper.Object,
                                                 mockLogger.Object);
            var result = await controller.UpdateAsset(1, editDto) as BadRequestObjectResult;

            Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal(ErrorCode.ASSET_IS_NOT_AVAILABLE, result.Value);

        }

        [Fact]
        public async Task EditAsset_With_Unknown_Exception_Return_BadRequest_With_ErrorCode()
        {
            var mockMapper = new Mock<IMapper>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockCategoryRepository = new Mock<ICategoryRepository>();
            var mockStateRepository = new Mock<IStateRepository>();
            var mockUserManager = new Mock<FakeUserManager>();
            var mockLogger = new Mock<ILogger<AssetController>>();

            var editDto = new EditAssetDTO
            {
                Name = "ABC",
                InstalledDate = DateTime.Now,
                Specification = "Testing",
                StateId = 3
            };

            var asset = new Asset
            {
                Id = 1,
                Name = "XYZ",
                Specification = "unit testing",
                StateID = 2,
                InstalledDate = DateTime.Now.AddDays(-10)
            };

            var updateAsset = new Asset
            {
                Id = 1,
                Name = editDto.Name,
                InstalledDate = editDto.InstalledDate,
                Specification = editDto.Specification,
                StateID = editDto.StateId
            };

            mockAssetRepository.Setup(a => a.GetAssetByIdAsync(It.IsAny<int>())).Returns(Task.FromResult<Asset?>(asset));

            mockMapper.Setup(m => m.Map(It.IsAny<EditAssetDTO>(), It.IsAny<Asset>())).Returns(updateAsset);

            mockAssetRepository.Setup(m => m.UpdateAsync(It.IsAny<Asset>())).Throws(new Exception());

            var controller = new AssetController(mockAssetRepository.Object,
                                                 mockCategoryRepository.Object,
                                                 mockStateRepository.Object,
                                                 mockUserManager.Object,
                                                 mockMapper.Object,
                                                 mockLogger.Object);
            var result = await controller.UpdateAsset(1, editDto) as BadRequestObjectResult;

            Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal(ErrorCode.EDIT_ASSET_FAILED, result.Value);
        }
        #endregion


        [Fact]
        public async Task Test_Asset_GetAssetList_Return_Asset_List_With_Pagination()
        {
            var mockMapper = new Mock<IMapper>();
            var mockAssetRepository = new Mock<IAssetRepository>();
            var mockCategoryRepository = new Mock<ICategoryRepository>();
            var mockStateRepository = new Mock<IStateRepository>();
            var mockUserManager = new Mock<FakeUserManager>();
            var mockLogger = new Mock<ILogger<AssetController>>();

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

            var controller = new AssetController(mockAssetRepository.Object,
                                                 mockCategoryRepository.Object,
                                                 mockStateRepository.Object,
                                                 mockUserManager.Object,
                                                 mockMapper.Object,
                                                 mockLogger.Object) { ControllerContext = controllerContext };

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