using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_HRMS.Domain.Models
{
    public class EmployeeReport
    {
            [Key]
            public int UserId { get; set; }

            public string Name { get; set; }

            public string Department { get; set; }

            public string PhoneNumber { get; set; }

            public string EmailId { get; set; }

        public string Status { get; set; }   // Active / Inactive
        public string Role { get; set; }     // Admin / HR / Developer
    }
}
