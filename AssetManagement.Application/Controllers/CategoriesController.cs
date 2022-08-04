using AssetManagement.Contracts.CategoryDTO;
using AssetManagement.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagement.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;
        public CategoriesController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await categoryRepository.GetAllAsync();
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync(CreateCategoryRequest request)
        {
            var result = await categoryRepository.CreateAsync(request);

            if (result.StatusCode == 400)
            {
                return BadRequest(result.Message);
            }

            return Ok(result.Message);
        }
    }
}
