using AssetManagement.Contracts.AssignmentDTO;
using AssetManagement.Contracts.Constant;
using AssetManagement.Data.Repositories;
using AssetManagement.Domain.Model;
using AssetManagement.Domain.Model.Enums;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AssetManagement.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentController : ControllerBase
    {
        private readonly IAssignmentRepository _assignmentRepository;
        private readonly ILogger<AssignmentController> _logger;
        private readonly IAssetRepository _assetRepository;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public AssignmentController(IAssignmentRepository assignmentRepository, IAssetRepository assetRepository, UserManager<User> userManager, IMapper mapper, ILogger<AssignmentController> logger)
        {
            _assignmentRepository = assignmentRepository;
            _assetRepository = assetRepository;
            _userManager = userManager;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAssignments([FromQuery] AssignmentParameters assignmentParameters)
        {
            try
            {
                var getAssignments = await _assignmentRepository.GetAsync(assignmentParameters.Searching, assignmentParameters.AssignDate, assignmentParameters.State, assignmentParameters.OrderBy);
                if (!getAssignments.Any()) return NotFound("Assignment List Empty");
                var assignmentListDTO = _mapper.Map<List<AssignmentDTO>>(getAssignments);
                return Ok(assignmentListDTO);
            }
            catch
            {
                return BadRequest("Something went wrong");
            }
        }

        [HttpGet("ByUserLogin")]
        [Authorize]
        public async Task<IActionResult> GetAssignmentsByUserLogin([FromQuery] UserAssignmentViewRequest request)
        {
            var data = await _assignmentRepository.GetUserAssignmentPaginationAsync(request);
            if (data == null)
            {
                return BadRequest();
            }
            return Ok(data);
        }

        [HttpPut("Accept/{id}")]
        [Authorize]
        public async Task<ActionResult> AcceptRespond(int id)
        {
            var result = await _assignmentRepository.AcceptRespondAsync(id);
            if (result.StatusCode == 400)
            {
                return BadRequest(result.Message);
            }
            else if (result.StatusCode == 404)
            {
                return NotFound(result.Message);
            }
            return Ok(result.Message);
        }

        [HttpPut("Decline/{id}")]
        [Authorize]
        public async Task<ActionResult> DeclineRespond(int id)
        {
            var result = await _assignmentRepository.DeclineRespondAsync(id);
            if (result.StatusCode == 400)
            {
                return BadRequest(result.Message);
            }
            else if (result.StatusCode == 404)
            {
                return NotFound(result.Message);
            }
            return Ok(result.Message);
        }

        [HttpPost("CreateAssignment")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateAssignment([FromBody] CreateAssignmentDTO createAssignmentDTO)
        {
            try
            {
                var username = HttpContext.User.Claims.Single(x => x.Type == ClaimTypes.Name).Value;

                var assignBy = await _userManager.FindByNameAsync(username);

                var assignTo = await _userManager.FindByIdAsync(createAssignmentDTO.UserId.ToString());

                if (assignTo is null)
                    return NotFound(ErrorCode.USER_NOT_FOUND);

                var asset = await _assetRepository.GetAssetByIdAsync(createAssignmentDTO.AssetId);

                if (asset is null)
                    return NotFound(ErrorCode.ASSET_NOT_FOUND);
                else if (asset.StateID != 2)
                    return BadRequest(ErrorCode.ASSET_IS_NOT_AVAILABLE);

                await _assignmentRepository.CreateAssignment(assignBy, assignTo, asset, createAssignmentDTO.AssignedDate, createAssignmentDTO.Note);

                return Ok(SuccessCode.CREATE_ASSIGNMENT_SUCCESSFULLY);
            }
            catch (Exception e)
            {
                _logger.LogError("ERROR FROM CREATE ASSIGNMENT", e.Message);
                return BadRequest(ErrorCode.CREATE_ASSIGNMENT_FAILED);
            }
        }

        [HttpPut("EditAssignment/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditAssignment(int id, [FromBody] CreateAssignmentDTO editAssignment)
        {
            try
            {
                var assignment = await _assignmentRepository.GetAssignmentAsync(id);

                if (assignment is null)
                    return NotFound(ErrorCode.ASSIGNMENT_NOT_FOUND);
                else if (assignment.AssignedState != AssignmentStateEnums.Waiting)
                    return BadRequest(ErrorCode.ASSIGNMENT_NOT_IN_WAITING_STATE);

                var assignTo = await _userManager.FindByIdAsync(editAssignment.UserId.ToString());

                if (assignTo is null)
                    return NotFound(ErrorCode.USER_NOT_FOUND);

                var asset = await _assetRepository.GetAssetByIdAsync(editAssignment.AssetId);

                if (asset is null)
                    return NotFound(ErrorCode.ASSET_NOT_FOUND);

                if (assignment.AssetId != editAssignment.AssetId && asset.StateID != 2)
                    return BadRequest(ErrorCode.ASSET_IS_NOT_AVAILABLE);
                else
                    await _assetRepository.SetAssetAvailable(assignment.Asset);

                var updateAssignment = _mapper.Map(editAssignment, assignment);

                await _assignmentRepository.UpdateAssignment(asset, assignTo, updateAssignment);

                return Ok(SuccessCode.EDIT_ASSIGNMENT_SUCCESSFULLY);
            }
            catch (Exception e)
            {
                _logger.LogError("ERROR FROM EDIT ASSIGNMENT", e.Message);
                return BadRequest(ErrorCode.EDIT_ASSIGNMENT_FAILED);
            }

        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult> GetAssignmentById(int id)
        {
            var data = await _assignmentRepository.GetAssignmentAsync(id);
            if (data == null)
            {
                return NotFound();
            }
            var dto = _mapper.Map<AssignmentDTO>(data);
            return Ok(dto);
        }

    }
}
