using System.ComponentModel.DataAnnotations;

namespace RepeateLessons.Database.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public int Age { get; set; }
    }
}
