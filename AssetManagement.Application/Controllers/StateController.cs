using AssetManagement.Application.Application.Interfaces;
using AssetManagement.Contracts.ViewModels;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace AssetManagement.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly IStateService _service;

        private readonly IMapper _mapper;

        public StateController(IStateService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet("")]
        public async Task<ActionResult> GetAllAsync()
        {
            var data = (await _service.GetAllAsync()).ToList();

            if (!data.Any())
            {
                return NotFound();
            }
            
            return Ok(data);
        }
    }
}