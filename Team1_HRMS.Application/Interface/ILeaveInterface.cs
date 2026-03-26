using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team1_HRMS.Domain.Models;
using Team1_HRMS.Application.DTO;


namespace Team1_HRMS.Application.Interface
{
    public interface ILeaveInterface
    {
        List<LeaveReportDTO> FetchLeaveReports(int page, int pageSize);
    }
}