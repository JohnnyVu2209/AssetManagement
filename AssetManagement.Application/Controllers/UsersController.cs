using AssetManagement.Application.Application.Interfaces;
using AssetManagement.Contracts.Request;
using AssetManagement.Contracts.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagement.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _service;

        public UsersController(IUserService service)
        {
            _service = service;
        }

        [HttpGet("{staffcode}")]
        public async Task<ActionResult> GetByStaffCode(string staffcode)
        {
            var data = await _service.GetByStaffCodeAsync(staffcode);
            if(data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        [HttpGet("")]
        public async Task<ActionResult> GetPaginationAsync([FromQuery] ViewUserRequest request)
        {
            var data = await _service.GetPaginationAsync(request);
            if (data == null)
            {
                return BadRequest();
            }
            return Ok(data);
        }
    }
}
