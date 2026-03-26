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
    public class AttendanceReportController : ControllerBase
    {
        IAttendanceInterface service;

        public AttendanceReportController(IAttendanceInterface service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("FetchAttendanceReports")]
        public IActionResult FetchAttendanceReports(int page = 1, int pageSize = 5)
        {
            var data = service.FetchAttendanceReports(page, pageSize);
            return Ok(APIResponses<List<AttendanceReportDTO>>
          .SuccessResponse(data, "Attendance reports fetched successfully"));
        }
    }
}