using AssetManagement.Application.Controllers;
using AssetManagement.Contracts.Constant;
using AssetManagement.Contracts.ReportDTO;
using AssetManagement.Data.Repositories;
using AssetManagement.Domain.Model;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace AssetManagement.Application.Tests.ControllersTests
{
    public class ReportControllerTests
    {
        [Fact]
        public async Task GetReport_Return_List_Report()
        {
            var mockReportRepository = new Mock<IReportRepository>();
            var mockMapper = new Mock<IMapper>();
            var mockLogger = new Mock<ILogger>();

            var report = new List<Report>()
            {
                new Report{Category = new Category{Name = "Test a"}, Assigned =1, Available = 1, Total = 2, NotAvailable = 0, Recycled = 0, WaitingForRecycling = 0},
                new Report{Category = new Category{Name = "Test B"}, Assigned =1, Available = 1, Total = 2, NotAvailable = 0, Recycled = 0, WaitingForRecycling = 0}
            };

            var reportDTO = new List<ReportDTO>()
            {
                new ReportDTO{ Category = report[0].Category.Name, Assigned = report[0].Assigned, Available = report[0].Available, Recycled = report[0].Recycled},
                new ReportDTO{ Category = report[1].Category.Name, Assigned = report[1].Assigned, Available = report[1].Available, Recycled = report[1].Recycled}
            };

            mockReportRepository.Setup(r => r.GetReport()).Returns(Task.FromResult(report));

            mockMapper.Setup(m => m.Map<List<ReportDTO>>(It.IsAny<List<Report>>())).Returns(reportDTO);

            var controller = new ReportController(mockReportRepository.Object, mockMapper.Object, mockLogger.Object);

            var result = await controller.GetReport() as OkObjectResult;

            Assert.IsType<OkObjectResult>(result);
            Assert.IsType<List<ReportDTO>>(result.Value);
        }
        [Fact]
        public async Task GetReport_Failed_Return_BadRequest_With_ErrorCode()
        {
            var mockReportRepository = new Mock<IReportRepository>();
            var mockMapper = new Mock<IMapper>();
            var mockLogger = new Mock<ILogger>();

            mockReportRepository.Setup(r => r.GetReport()).Throws(new Exception());

            var controller = new ReportController(mockReportRepository.Object, mockMapper.Object, mockLogger.Object);

            var result = await controller.GetReport() as BadRequestObjectResult;

            Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal(ErrorCode.GET_REPORT_FAILED, result.Value);
        }
    }
}
