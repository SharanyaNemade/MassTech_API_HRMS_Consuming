using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using Team1_HRMS.Application.DTO;
using Team1_HRMS.Application.Interface;
using Team1_HRMS.Infrastructure.Services;

namespace Team1_HRMSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableRateLimiting("fixed")]
    public class LeaveReportController : ControllerBase
    {
        ILeaveInterface service;

        public LeaveReportController(ILeaveInterface service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("FetchLeaveReports")]
        public IActionResult FetchLeaveReports(int page = 1, int pageSize = 5)
        {
            var data = service.FetchLeaveReports(page, pageSize);
            return Ok(APIResponses<List<LeaveReportDTO>>
          .SuccessResponse(data, "Leave reports fetched successfully"));
        }
    }
}