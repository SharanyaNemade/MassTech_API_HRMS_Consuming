using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_HRMS.Domain.Models
{
    public class ProjectReport
    {
        [Key]
        public int ProjectId { get; set; }

        public string ProjectName { get; set; }

        public string Leader { get; set; }

        public string Members { get; set; } // comma-separated or simple string

        public DateTime Deadline { get; set; }

        public string Priority { get; set; }

        public string Status { get; set; }
    }
}