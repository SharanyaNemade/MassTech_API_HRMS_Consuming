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
    public class EmployeeReportController : ControllerBase
    {
        
        IEmpInterface service;

        public EmployeeReportController(IEmpInterface service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("FetchEmployeeReports")]
        public IActionResult FetchEmployeeReports(int page = 1, int pageSize = 5)
        {
            var data = service.FetchEmployeeReports(page, pageSize);
            //return Ok(APIResponses<EmpReportDTO>.SuccessResponse(data, "Event Type Added"));

            return Ok(APIResponses<List<EmpReportDTO>>
          .SuccessResponse(data, "Employee reports fetched successfully"));
        }  
            

        [HttpGet]
        [Route("Dashboard")]
        public IActionResult GetDashboard()
        {
            var data = service.GetEmployeeDashboard();
            return Ok(data);
        }
    }
}

