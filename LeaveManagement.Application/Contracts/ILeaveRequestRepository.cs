using LeaveManagement.Data;
using LeaveManagement.Common.Models;

namespace LeaveManagement.Application.Contracts
{
    public interface ILeaveRequestRepository: IGenericRepository<LeaveRequest>
    {
        Task<bool> CreateLeaveRequest(LeaveRequestCreateVM model);
        Task<EmployeeLeaveRequestVM> GetMyLeaveDetails();
        Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id);
        Task<List<LeaveRequest>> GetAllAsync(string employeeId);

        Task<bool> ChangeApprovalStatus(int leaveReuestId, bool approved);
        Task<bool> CancelLeaveRequest(int leaveReuestId);
        Task<AdminLeaveRequestsViewVM> GetAdminLeaveRequestList();


    }

}
