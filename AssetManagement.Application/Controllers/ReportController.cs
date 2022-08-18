using AssetManagement.Contracts.Constant;
using AssetManagement.Contracts.ReportDTO;
using AssetManagement.Data.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagement.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportRepository _reportRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<ReportController> _logger;
        public ReportController(IReportRepository reportRepository, IMapper mapper, ILogger<ReportController> logger)
        {
            _reportRepository = reportRepository;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetReport()
        {
            try
            {
                var report = await _reportRepository.GetReport();
                var reportDto = _mapper.Map<List<ReportDTO>>(report);
                return Ok(reportDto);
            }
            catch (Exception e)
            {
                _logger.LogError("Error from Report", e.Message);
                return BadRequest(ErrorCode.GET_REPORT_FAILED);
            }
            
        }
    }
}
