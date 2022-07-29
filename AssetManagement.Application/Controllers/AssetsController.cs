using AssetManagement.Application.Application.Interfaces;
using AssetManagement.Contracts.ViewModels;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace AssetManagement.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetsController : ControllerBase
    {
        private readonly IAssetService _service;

        private readonly IMapper _mapper;

        public AssetsController(IAssetService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet("")]
        public async Task<ActionResult> GetAllSync()
        {
            var data = _mapper.Map<List<AssetDTO>>((await _service.GetAllAsync()).ToList());

            if (data == null)
            {
                return NotFound();
            }
            
            return Ok(data);
        }

        [HttpGet("{assetCode}")]
        public async Task<ActionResult> GetByStaffCode(string assetCode)
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