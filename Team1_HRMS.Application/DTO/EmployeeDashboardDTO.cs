using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_HRMS.Application.DTO
{
    namespace Team1_HRMS.Application.DTO
    {
        public class EmployeeDashboardDTO
        {
            public int TotalEmployees { get; set; }
            public int TotalDepartments { get; set; }
            public int ActiveEmployees { get; set; }
            public int TotalRoles { get; set; }

            // For Graph
            public List<string> Labels { get; set; }   
            public List<int> ActiveData { get; set; }
            public List<int> InactiveData { get; set; }
        }
    }
}
