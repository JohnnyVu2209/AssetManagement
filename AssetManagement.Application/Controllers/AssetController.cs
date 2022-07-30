using AssetManagement.Application.Application.Interfaces;
using AssetManagement.Contracts.ViewModels;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace AssetManagement.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetController : ControllerBase
    {
        private readonly IAssetService _service;

        private readonly IMapper _mapper;

        public AssetController(IAssetService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet("")]
        public async Task<ActionResult> GetAllByCurrentAdminLocationAsync()
        {
            var data = _mapper.Map<List<AssetDTO>>(
                (await _service.GetAllByCurrentAdminLocationAsync()).ToList());

            if (!data.Any())
            {
                return NotFound();
            }
            
            return Ok(data);
        }

        [HttpGet("all")]
        public async Task<ActionResult> GetAllAsync()
        {
            var data = _mapper.Map<List<AssetDTO>>(
                (await _service.GetAllAsync()).ToList());

            if (!data.Any())
            {
                return NotFound();
            }
            
            return Ok(data);
        }

        [HttpGet("{assetCode}")]
        public async Task<ActionResult> GetByAssetCodeAsync(string assetCode)
        {
            var data = _mapper.Map<AssetDetailDTO>((await _service.GetByAssetCodeAsync(assetCode)));

            if (data == null)
            {
                return NotFound();
            }

            return Ok(data);
        }
    }
}