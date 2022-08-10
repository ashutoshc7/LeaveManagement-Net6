using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementWeb.Data
{
    public class LeaveAllocation:BaseEntity  //Leave allocation means an employee having certain number of days allocated to them based on the leave type
    {
    
        public int NumberOfDays { get; set; }
        [ForeignKey("LeaveId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveId { get; set; }
        public string EmployeeId { get; set; }
      
    }
}
