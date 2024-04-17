using AutoMapper;
using LeaveManagement.Web.Constants;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<Employee> userManager;
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly IMapper mapper;

        public LeaveAllocationRepository(ApplicationDbContext context,
            UserManager<Employee> userManager,
            ILeaveTypeRepository leaveTypeRepository,
            IMapper mapper) : base(context)
        {
            this.context = context;
            this.userManager = userManager;
            this.leaveTypeRepository = leaveTypeRepository;
            this.mapper = mapper;
        }

        public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string userId)
        {
            var allocations = await context.LeaveAllocations
                .Include(q => q.LeaveType)
                .Where(q => q.EmployeeId == userId).ToListAsync();
            var employee = await userManager.FindByIdAsync(userId);
            var empAllocationVM = mapper.Map<EmployeeAllocationVM>(employee);
            empAllocationVM.LeaveAllocations = mapper.Map<List<LeaveAllocationVM>>(allocations);
            return empAllocationVM;
        }

        public async Task<EditLeaveAllocationVM> GetEmployeeAllocation(int id)
        {
            var allocation = await context.LeaveAllocations
                .Include(q => q.LeaveType)
                .FirstOrDefaultAsync(q => q.Id == id);
            if(allocation == null)
            {
                return null;
            }

            var empAllocationVM = mapper.Map<EditLeaveAllocationVM>(allocation);
            empAllocationVM.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(allocation.EmployeeId)); ;
            return empAllocationVM;
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

        public async Task<bool> UpdateEmployeeLeaveAllocation(EditLeaveAllocationVM model)
        {
            var leaveAllocation = await GetAsync(model.Id);
            if (leaveAllocation == null)
            {
                return false;
            }
            leaveAllocation.Period = model.Period;
            leaveAllocation.NumberOfDays = model.NumberOfDays;
            await UpdateAsync(leaveAllocation) ; 
            return true;
        }

        public async Task<LeaveAllocation?> GetEmployeeAllocation(string userId, int leaveTypeId)
        {
           return await context.LeaveAllocations.FirstOrDefaultAsync(q => q.EmployeeId == userId && q.LeaveTypeId == leaveTypeId);
        }
    }
}
