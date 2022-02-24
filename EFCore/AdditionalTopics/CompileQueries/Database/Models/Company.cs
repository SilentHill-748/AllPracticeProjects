using System.Collections.Generic;

namespace CompileQueries.Database.Models
{
    public class Company
    {
        public Company()
        {
            Users = new List<User>();
        }



        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<User> Users { get; set; }
    }
}
