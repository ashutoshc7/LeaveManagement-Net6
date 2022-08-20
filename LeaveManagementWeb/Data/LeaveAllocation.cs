using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementWeb.Data
{
    public class LeaveAllocation:BaseEntity  //Leave allocation means an employee having certain number of days allocated to them based on the leave type
    {
    
        public int NumberOfDays { get; set; }
        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public string EmployeeId { get; set; }
        public int Period { get; set; }//This is a year like 2021 or 2022 (you got these number of days for this year)

      
    }
}
