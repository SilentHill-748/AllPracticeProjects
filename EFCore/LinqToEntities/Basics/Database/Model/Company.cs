using System.Collections.Generic;

namespace Basics.Database.Model
{
    public class Company
    {
        public Company()
        {
            Users = new List<User>();
        }

        public int Id { get; set; }

        public string Name { get; set; }



        public int CountryId { get; set; }

        public Country Country { get; set; }



        public List<User> Users { get; set; }
    }
}
