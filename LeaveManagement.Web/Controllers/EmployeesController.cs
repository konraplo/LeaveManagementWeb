using AutoMapper;
using LeaveManagement.Web.Constants;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace LeaveManagement.Web.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IMapper mapper;
        private readonly ILeaveAllocationRepository leaveAllocationRepository;
        private readonly ILeaveTypeRepository leaveTypeRepository;

        public UserManager<Employee> userManager { get; }

        public EmployeesController(UserManager<Employee> userManager, IMapper mapper, 
            ILeaveAllocationRepository leaveAllocationRepository,
            ILeaveTypeRepository leaveTypeRepository)
        {
            this.userManager = userManager;
            this.mapper = mapper;
            this.leaveAllocationRepository = leaveAllocationRepository;
            this.leaveTypeRepository = leaveTypeRepository;
        }
        // GET: EmployeesController
        public async Task<IActionResult> Index()
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var model = mapper.Map<List<EmployeeListVM>>(employees);
            return View(model);
        }

        // GET: EmployeesController/ViewAllocations/EmpId
        public async Task<IActionResult> ViewAllocations(string id)
        {
            var model = await leaveAllocationRepository.GetEmployeeAllocation(id);
            return View(model);
        }

        
        // GET: EmployeesController/EditAllocation/5
        public async Task<ActionResult> EditAllocation(int id)
        {
            var leaveAllocation = await this.leaveAllocationRepository.GetEmployeeAllocation(id);
            if (leaveAllocation == null)
            {
                return NotFound();
            }
            return View(leaveAllocation);
        }

        // POST: EmployeesController/EditAllocation/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAllocation(int id, EditLeaveAllocationVM model)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    if (await  this.leaveAllocationRepository.UpdateEmployeeLeaveAllocation(model))
                    {
                        return RedirectToAction(nameof(ViewAllocations), new { id = model.EmployeeId });
                    }
                }
            }
            catch(Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            model.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(model.EmployeeId));
            model.LeaveType = mapper.Map<LeaveTypeVM>(await this.leaveTypeRepository.GetAsync(model.LeaveTypeId));
            return View(model);
        }

    }
}
