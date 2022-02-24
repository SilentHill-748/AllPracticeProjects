namespace Relationships.Database.Entities
{
    public class User
    {
        public int UserId { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public int ProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}
