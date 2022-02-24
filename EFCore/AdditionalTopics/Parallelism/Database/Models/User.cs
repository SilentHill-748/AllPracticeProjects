using System.ComponentModel.DataAnnotations;

namespace Parallelism.Database.Models
{
    public class User
    {
        public int Id { get; set; }

        [ConcurrencyCheck]
        public string Name { get; set; }

        public int Age { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }

        public byte[] Test { get; set; }


        public int UserProfileId { get; set; }

        public UserProfile UserProfile { get; set; }
    }
}
