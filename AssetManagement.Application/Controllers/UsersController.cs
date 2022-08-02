using AssetManagement.Application.Application.Interfaces;
using AssetManagement.Contracts.UserDTO;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize(Roles = "Admin")]
        [HttpGet()]
        public async Task<ActionResult> GetPagination([FromQuery] ViewUserRequest request)
        {
            var data = await _service.GetPaginationAsync(request);
            if (data == null)
            {
                return BadRequest();
            }
            return Ok(data);
        }

        [Authorize(Roles ="Admin")]
        [HttpPut]
        public async Task<ActionResult> Update([FromBody] UpdateUserRequest request)
        {
            var res = await _service.UpdateAsync(request);
            if (res == true)
                return Ok(res);
            else
                return BadRequest(res);
        }

        [HttpGet("roles")]
        public async Task<ActionResult> GetRoles()
        {
            var res = await _service.GetRolesAsync();
            if(res == null) return BadRequest();
            return Ok(res);
        }   
    }
}
