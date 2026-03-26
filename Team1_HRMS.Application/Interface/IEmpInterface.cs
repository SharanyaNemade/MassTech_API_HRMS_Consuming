using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team1_HRMS.Domain.Models;
using Team1_HRMS.Application.DTO;
using Team1_HRMS.Application.DTO.Team1_HRMS.Application.DTO;



namespace Team1_HRMS.Application.Interface
{
    public interface IEmpInterface
    {
        List<EmpReportDTO> FetchEmployeeReports(int page, int pageSize);

        EmployeeDashboardDTO GetEmployeeDashboard();
    }
}
