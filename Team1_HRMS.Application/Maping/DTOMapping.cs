using Team1_HRMS.Application.DTO;
using Team1_HRMS.Domain.Models;
using AutoMapper;

namespace Team1_HRMS.Application.Maping
{
    public class DTOMapping : Profile
    {
        public DTOMapping()
        {
            CreateMap<EmployeeReport, EmpReportDTO>();

            CreateMap<AttendanceReport, AttendanceReportDTO>();

            CreateMap<LeaveReport, LeaveReportDTO>();

            CreateMap<PayslipReport, PayslipReportDTO>();

            CreateMap<ProjectReport, ProjectReportDTO>();

            CreateMap<TaskReport, TaskReportDTO>();

            CreateMap<DailyReport, DailyReportDTO>();
        }
    }
}
