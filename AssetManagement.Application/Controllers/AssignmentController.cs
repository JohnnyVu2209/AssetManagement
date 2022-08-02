using AssetManagement.Contracts.AssignmentDTO;
using AssetManagement.Data.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> GetAssignments([FromQuery] AssignmentParameters assignmentParameters)
        {
            try
            {
                var getAssignments = await _assignmentRepository.GetAsync();
                if (!getAssignments.Any()) return NotFound("Assignment List Empty");
                if (getAssignments.Any() && !string.IsNullOrWhiteSpace(assignmentParameters.Searching))
                    getAssignments = getAssignments.Where(x => x.AssetCode.Contains(assignmentParameters.Searching) || x.AssetName.Contains(assignmentParameters.Searching) || x.AssignTo.Contains(assignmentParameters.Searching));
                if (getAssignments.Any() && assignmentParameters.State != null && assignmentParameters.State.Count != 0)
                    getAssignments = getAssignments.Where(x => assignmentParameters.State.Contains(x.AssignmentState));
                if (getAssignments.Any() && assignmentParameters.AssignDate != null)
                    getAssignments = getAssignments.Where(x => x.AssignDate == assignmentParameters.AssignDate);
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
