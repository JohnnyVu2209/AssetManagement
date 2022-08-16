using AssetManagement.Contracts.ReturnRequestDTO;
using AssetManagement.Data.Repositories;
using AssetManagement.Domain.Model.Enums;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagement.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReturnRequestController : ControllerBase
    {
        private readonly IReturnRequestRepository _returnRequestRepository;
        private readonly IMapper _mapper;

        public ReturnRequestController(IReturnRequestRepository returnRequestRepository, IMapper mapper)
        {
            _returnRequestRepository = returnRequestRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetReturnRequests([FromQuery] ReturnRequestParameters returnRequestParameters)
        {
            try
            {
                var getReturnRequests = await _returnRequestRepository.GetAsync(returnRequestParameters.Searching, returnRequestParameters.ReturnedDate, returnRequestParameters.State);
                if (!getReturnRequests.Any()) return NotFound("Return Request List Empty");
                var returnRequestListDTO = _mapper.Map<List<ReturnRequestDTO>>(getReturnRequests);
                return Ok(returnRequestListDTO);
            }
            catch
            {
                return BadRequest("Something went wrong");
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetReturnRequestById(int id)
        {
            try
            {
                var getReturnRequest = await _returnRequestRepository.GetAsyncById(id);
                if (getReturnRequest == null) return NotFound("Return request not found");
                var getReturnRequestDTO= _mapper.Map<ReturnRequestDTO>(getReturnRequest);
                return Ok(getReturnRequestDTO);
            }
            catch
            {
                return BadRequest("Something went wrong");
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}/{state}")]

        public async Task<IActionResult> UpdateReturnRequestState(int id,bool state)
        {
            try
            {
                var getReturnRequest = await _returnRequestRepository.GetAsyncById(id);
                if (getReturnRequest == null) return NotFound("Return request not found");
                if (getReturnRequest.State == ReturnRequestStateEnums.Completed) return BadRequest("Return request already accepted");
                await _returnRequestRepository.PutAsync(id, state);
                return Ok("Return request state updated"); 
            }
            catch
            {
                return BadRequest("Something went wrong");
            }
        }

    }
}
