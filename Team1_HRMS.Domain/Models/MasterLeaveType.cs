using System.ComponentModel.DataAnnotations;

namespace Team1_HRMS.Domain.Models
{
    public class MasterLeaveType
    {
        [Key]
        public int LeaveTypeId { get; set; }
        public string LeaveType { get; set; }

        public List<DepartmentLeaves> DepartmentLeaves { get; set; }
        public List<LeaveBalance> LeaveBalances { get; set; }
        public List<LeaveRequest> LeaveRequests { get; set; }
    }
}
