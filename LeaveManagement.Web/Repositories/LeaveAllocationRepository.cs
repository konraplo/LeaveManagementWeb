using LeaveManagement.Web.Constants;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<Employee> userManager;
        private readonly ILeaveTypeRepository leaveTypeRepository;

        public LeaveAllocationRepository(ApplicationDbContext context,
            UserManager<Employee> userManager,
            ILeaveTypeRepository leaveTypeRepository) : base(context)
        {
            this.context = context;
            this.userManager = userManager;
            this.leaveTypeRepository = leaveTypeRepository;
        }

        public async Task LeaveAllocation(int id)
        {
            var employess = await userManager.GetUsersInRoleAsync(Roles.User);
            var period = DateTime.Now.Year;
            var leaveType = await leaveTypeRepository.GetAsync(id);
            var allocations = new List<LeaveAllocation>();
            foreach (var user in employess)
            {
                if(await LeaveAllocationExists(user.Id,id, period))
                {
                    continue;
                }

                allocations.Add(new LeaveAllocation
                {
                    EmployeeId = user.Id,
                    LeaveTypeId = id,
                    Period = period,
                    NumberOfDays = leaveType.DefaultDays,
                });
            }
            await AddRangeAsync(allocations);
        }

        public async Task<bool> LeaveAllocationExists(string userId, int id, int period)
        {
            return await context.LeaveAllocations.AnyAsync(q => q.EmployeeId == userId && q.LeaveTypeId == id && q.Period == period);
        }
    }
}
