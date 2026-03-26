using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team1_HRMS.Domain.Models;

namespace Team1_HRMS.Application.DTO
{
   public class AttendanceReportDTO
    {
        public int AttendanceId { get; set; }

        public string EmployeeName { get; set; }

        public DateTime Date { get; set; }

        public string CheckIn { get; set; }

        public string CheckOut { get; set; }

        public string LunchIn { get; set; }

        public string LunchOut { get; set; }

        public string Status { get; set; }

        public double WorkingHours { get; set; }

        public double OvertimeHours { get; set; }

        public double BreakHours { get; set; }

        public int Late { get; set; }

        public double ProductionHours { get; set; }
    }
}
