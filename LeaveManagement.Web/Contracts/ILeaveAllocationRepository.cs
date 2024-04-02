using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Contracts
{
    public interface ILeaveAllocationRepository: IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int id);
        Task<bool> LeaveAllocationExists(string userId, int id, int period);
        Task<EmployeeAllocationVM> GetEmployeeAllocation(string userId);
        Task<EditLeaveAllocationVM> GetEmployeeAllocation(int id);
        Task<bool> UpdateEmployeeLeaveAllocation(EditLeaveAllocationVM model);


    }
}
