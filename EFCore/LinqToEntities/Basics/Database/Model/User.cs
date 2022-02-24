namespace Basics.Database.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int UserRoleId { get; set; }
        public UserRole UserRole { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
