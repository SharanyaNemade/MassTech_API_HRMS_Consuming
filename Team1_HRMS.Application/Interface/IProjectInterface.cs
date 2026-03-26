using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team1_HRMS.Domain.Models;
using Team1_HRMS.Application.DTO;

namespace Team1_HRMS.Application.Interface
{
    public interface IProjectInterface
    {
        List<ProjectReportDTO> FetchProjectReports(int page, int pageSize);
    }
}