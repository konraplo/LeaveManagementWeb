using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class EmployeeListVM
    {

        public string Id { get; set; }
        [Display(Name = "First name")]
        public string? Firstname { get; set; }
        [Display(Name = "Last name")]
        public string? Lastname { get; set; }
        [Display(Name = "Date joined")]
        public DateTime DateOfJoin { get; set; }

        public string Email { get; set; }
    }
}
