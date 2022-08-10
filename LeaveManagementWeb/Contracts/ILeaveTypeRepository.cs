using LeaveManagementWeb.Data;

namespace LeaveManagementWeb.Contracts
{
    public interface ILeaveTypeRepository:IGenericRepository<LeaveType> //This ILeaveTypeRepository is the custom repository built on the top of the generic one 
    {
    }
}
