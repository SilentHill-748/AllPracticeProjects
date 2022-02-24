namespace TPH.Database.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Discriminator { get; set; }
    }
}
