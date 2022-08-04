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
        private readonly UserManager<User> userManager;
        public AssetController(IMapper mapper, IAssetRepository assetRepository, UserManager<User> userManager)
        {
            this.mapper = mapper;
            this.userManager = userManager;
            this.assetRepository = assetRepository;
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