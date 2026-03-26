using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team1_HRMS.Domain.Models;
using Team1_HRMS.Application.DTO;

namespace Team1_HRMS.Application.Interface
{
    
    public interface IAttendanceInterface
    {
        List<AttendanceReportDTO> FetchAttendanceReports(int page, int pageSize);
    }

}

