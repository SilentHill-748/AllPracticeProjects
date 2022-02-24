namespace Relationships.Database.Entities
{
    public class UserProfile
    {
        public int UserProfileId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public User User { get; set; }
    }
}
