using System.Collections.Generic;

namespace Basics.Database.Models
{
    public class Company
    {
        public Company()
        {
            Users = new List<User>();
        }


        public int Id { get; set; }

        public string Name { get; set; }

        public List<User> Users { get; set; }
    }
}
