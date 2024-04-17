using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Contracts
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
