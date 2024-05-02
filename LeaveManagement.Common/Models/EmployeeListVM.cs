using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Common.Models
{
    public class EmployeeListVM
    {

        public string Id { get; set; }
        [Display(Name = "First name")]
        public string? Firstname { get; set; }
        [Display(Name = "Last name")]
        public string? Lastname { get; set; }
        [Display(Name = "Date joined")]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime DateOfJoin { get; set; }

        [Display(Name = "Email address")]
        public string Email { get; set; }
    }
}
