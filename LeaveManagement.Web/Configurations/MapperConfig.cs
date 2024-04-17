using AutoMapper;
using LeaveManagement.Web.Data;

namespace LeaveManagement.Web.Configurations
{
    public class MapperConfig: Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, Models.LeaveTypeVM>().ReverseMap();
            CreateMap<Employee, Models.EmployeeListVM>().ReverseMap();
            CreateMap<Employee, Models.EmployeeAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocation, Models.LeaveAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocation, Models.EditLeaveAllocationVM>().ReverseMap();
            CreateMap<LeaveRequest, Models.LeaveRequestCreateVM>().ReverseMap();
            CreateMap<LeaveRequest, Models.LeaveRequestVM>().ReverseMap();
        }
    }
}
