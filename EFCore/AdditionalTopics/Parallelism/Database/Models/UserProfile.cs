using System;
using System.ComponentModel.DataAnnotations;

namespace Parallelism.Database.Models
{
    public class UserProfile
    {
        public int Id { get; set; }

        public DateTime DateOfEnrollment { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
