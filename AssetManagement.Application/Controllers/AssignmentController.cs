using AssetManagement.Contracts.AssignmentDTO;
using AssetManagement.Data.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AssetManagement.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentController : ControllerBase
    {
        private readonly IAssignmentRepository _assignmentRepository;
        private readonly IMapper _mapper;

        public AssignmentController(IAssignmentRepository assignmentRepository, IMapper mapper)
        {
            _assignmentRepository = assignmentRepository;
            _mapper = mapper;
        }

        [HttpGet]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAssignments([FromQuery] AssignmentParameters assignmentParameters)
        {
            try
            {
                var getAssignments = await _assignmentRepository.GetAsync(assignmentParameters.Searching,assignmentParameters.AssignDate, assignmentParameters.State);
                if (!getAssignments.Any()) return NotFound("Assignment List Empty");
                var assignmentListDTO = _mapper.Map<List<AssignmentDTO>>(getAssignments);
                return Ok(assignmentListDTO);
            }
            catch
            {
                return BadRequest("Something went wrong");
            }
        }
    }
}
