using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementWeb.Data
{
    public class LeaveAllocation:BaseEntity
    {
    
        public int NumberOfDays { get; set; }
        [ForeignKey("LeaveId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveId { get; set; }
        public string EmployeeId { get; set; }
      
    }
}
