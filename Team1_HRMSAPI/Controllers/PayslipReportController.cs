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
    public class PayslipReportController : ControllerBase
    {
        IPayslipInterface service;

        public PayslipReportController(IPayslipInterface service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("FetchPayslipReports")]
        public IActionResult FetchPayslipReports(int page = 1, int pageSize = 5)
        {
            var data = service.FetchPayslipReports(page, pageSize);
            return Ok(APIResponses<List<PayslipReportDTO>>
          .SuccessResponse(data, "Payslip reports fetched successfully"));
        }
    }
}