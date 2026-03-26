using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using Team1_HRMS.Application.DTO;
using Team1_HRMS.Application.Interface;
using Team1_HRMS.Infrastructure.Services;


namespace Team1_HRMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableRateLimiting("fixed")]
    public class TaskReportController : ControllerBase
    {
        ITaskInterface service;

        public TaskReportController(ITaskInterface service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("FetchTaskReports")]
        public IActionResult FetchTaskReports(int page = 1, int pageSize = 5)
        {
            var data = service.FetchTaskReports(page, pageSize);
            return Ok(APIResponses<List<TaskReportDTO>>
          .SuccessResponse(data, "Employee reports fetched successfully"));
        }
    }
}