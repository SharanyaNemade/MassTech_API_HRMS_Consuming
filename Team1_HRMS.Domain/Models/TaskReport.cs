using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_HRMS.Domain.Models
{
    public class TaskReport
    {
        [Key]
        public int TaskId { get; set; }

        public string TaskName { get; set; }

        public string ProjectName { get; set; }

        public DateTime DueDate { get; set; }

        public string Priority { get; set; }

        public string Status { get; set; }
    }
}