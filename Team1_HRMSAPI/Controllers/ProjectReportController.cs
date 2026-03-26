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
    public class ProjectReportController : ControllerBase
    {
        IProjectInterface service;

        public ProjectReportController(IProjectInterface service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("FetchProjectReports")]
        public IActionResult FetchProjectReports(int page = 1, int pageSize = 5)
        {
            var data = service.FetchProjectReports(page, pageSize);
            return Ok(APIResponses<List<ProjectReportDTO>>
          .SuccessResponse(data, "Project reports fetched successfully"));
        }
    }
}