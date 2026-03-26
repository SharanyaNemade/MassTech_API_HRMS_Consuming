using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.AspNetCore.Mvc;
using Team1_HRMS.Application.DTO;
using Team1_HRMS.Application.Interface;
using Team1_HRMS.Infrastructure.Services;



namespace Team1_HRMSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableRateLimiting("fixed")]
    public class DailyReportController : ControllerBase
    {
        IDailyInterface service;

        public DailyReportController(IDailyInterface service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("FetchDailyReports")]
        public IActionResult FetchDailyReports(int page = 1, int pageSize = 5)
        {
            var data = service.FetchDailyReports(page, pageSize);
            return Ok(APIResponses<List<DailyReportDTO>>
          .SuccessResponse(data, "Daily reports fetched successfully"));
        }
    }
}