using AssetManagement.Contracts;
using AssetManagement.Contracts.AssetDTO;
using AssetManagement.Data.Repositories;
using AssetManagement.Domain.Model;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Claims;

namespace AssetManagement.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IAssetRepository assetRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly IStateRepository stateRepository;
        private readonly UserManager<User> userManager;
        public AssetController(IAssetRepository assetRepository, ICategoryRepository categoryRepository, IStateRepository stateRepository, UserManager<User> userManager, IMapper mapper)
        {
            this.mapper = mapper;
            this.userManager = userManager;
            this.assetRepository = assetRepository;
            this.stateRepository = stateRepository;
            this.categoryRepository = categoryRepository;
        }
        [HttpGet("getAssetsList")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> GetAllAsync([FromQuery] AssetParameters assetParameters)
        {
            var username = HttpContext.User.Claims.Single(x => x.Type == ClaimTypes.Name).Value;

            var user = await userManager.FindByNameAsync(username);

            var filterAsset = assetRepository.GetAssetsByFilter(user.LocationId,
                                                                assetParameters.State,
                                                                assetParameters.Category,
                                                                assetParameters.Searching,
                                                                assetParameters.OrderBy);

            var pagingAsset = PageList<Asset, AssetDTO>.ToPageList(filterAsset, assetParameters.PageNumber, assetParameters.PageSize, mapper);

            var metadata = new
            {
                pagingAsset.TotalCount,
                pagingAsset.PageSize,
                pagingAsset.CurrentPage,
                pagingAsset.TotalPages,
                pagingAsset.HasNext,
                pagingAsset.HasPrevious,
                assetParameters.State,
                assetParameters.Category
            };

            Response.Headers.Add("Pagination", JsonConvert.SerializeObject(metadata));

            return Ok(pagingAsset);
        }
        [HttpGet("GetCategories")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await categoryRepository.GetAllCategoriesAsync();
            var dto = mapper.Map<List<AssetCategoryDTO>>(categories);
            return Ok(dto);
        }

        [HttpGet("GetStates")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetStates()
        {
            var states = await stateRepository.GetAllAsync();
            var dto = mapper.Map<List<AssetStateDTO>>(states);
            return Ok(dto);
        }


        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> CreateAsync(CreateAssetRequest request)
        {
            var result = await assetRepository.CreateAsync(request);
            if (result.StatusCode == 400)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }
    }
}