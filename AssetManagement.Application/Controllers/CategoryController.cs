using AssetManagement.Application.Application.Interfaces;
using AssetManagement.Contracts.ViewModels;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace AssetManagement.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;

        private readonly IMapper _mapper;

        public CategoryController(ICategoryService service, IMapper mapper)
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