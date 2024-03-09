namespace LeaveManagement.Web.Data
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfJoin { get; set; }
    }
}
