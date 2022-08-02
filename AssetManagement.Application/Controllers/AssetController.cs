using AssetManagement.Application.Application.Interfaces;
using AssetManagement.Contracts.ViewModels;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using AssetManagement.Contracts.AssetDTO;
using AssetManagement.Data;
using AssetManagement.Contracts;
using AssetManagement.Domain.Model;
using System.Reflection;
using System.Linq.Dynamic.Core;
using System.Text;
using AssetManagement.Data.Repositories.Extensions;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace AssetManagement.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;

        private readonly UserManager<User> _userManager;

        public AssetController(IUnitOfWork unitOfWork, IMapper mapper, UserManager<User> userManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
        }

        /*     [HttpGet("")]
             public async Task<ActionResult> GetAllByCurrentAdminLocationAsync()
             {
                 var data = _mapper.Map<List<AssetDTO>>(
                     (await _service.GetAllByCurrentAdminLocationAsync()).ToList());

                 if (!data.Any())
                 {
                     return NotFound();
                 }

                 return Ok(data);
             }*/

        [HttpGet("all")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> GetAllAsync([FromQuery]AssetParameters assetParameters)
        {
            var username = HttpContext.User.Claims.Single(x => x.Type == ClaimTypes.Name).Value;

            var user = await _userManager.FindByNameAsync(username);

            var assets = (await _unitOfWork.Assets.GetAllAsync()).Where(x => x.LocationID == user.LocationId).AsQueryable();

            if (assets.Any() && !string.IsNullOrWhiteSpace(assetParameters.Searching))
                assets = assets.Where(x => x.Name.Contains(assetParameters.Searching) || x.Code.Contains(assetParameters.Searching));

            if(assets.Any() && assetParameters.State != null && assetParameters.State.Count != 0)
                assets = assets.Where(x => assetParameters.State.Contains(x.StateID));

            if (assets.Any() && assetParameters.Category != null && assetParameters.Category.Count != 0 )
                assets = assets.Where(x => assetParameters.Category.Contains(x.CategoryID));

            assets = assets.ApplySort(assetParameters.OrderBy);


            var pageList = PageList<Asset,AssetDTO>.ToPageList(assets, assetParameters.PageNumber, assetParameters.PageSize, _mapper);

            var metadata = new
            {
                pageList.TotalCount,
                pageList.PageSize,
                pageList.CurrentPage,
                pageList.TotalPages,
                pageList.HasNext,
                pageList.HasPrevious,
                assetParameters.State,
                assetParameters.Category
            };

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));

            return Ok(pageList);
        }
    }
}