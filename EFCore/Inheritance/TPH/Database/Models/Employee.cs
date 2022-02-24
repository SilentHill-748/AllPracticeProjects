namespace TPH.Database.Models
{
    public class Employee : User
    {
        public decimal Salary { get; set; }

        public int Experience { get; set; }
    }
}
