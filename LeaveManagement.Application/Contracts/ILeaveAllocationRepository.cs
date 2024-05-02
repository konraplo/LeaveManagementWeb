using LeaveManagement.Data;
using LeaveManagement.Common.Models;

namespace LeaveManagement.Application.Contracts
{
    public interface ILeaveAllocationRepository: IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int id);
        Task<bool> LeaveAllocationExists(string userId, int id, int period);
        Task<EmployeeAllocationVM> GetEmployeeAllocations(string userId);
        Task<LeaveAllocation?> GetEmployeeAllocation(string userId, int leaveTypeId);
        Task<EditLeaveAllocationVM> GetEmployeeAllocation(int id);
        Task<bool> UpdateEmployeeLeaveAllocation(EditLeaveAllocationVM model);


    }
}
