using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Display(Name = "Default number of days")]
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
