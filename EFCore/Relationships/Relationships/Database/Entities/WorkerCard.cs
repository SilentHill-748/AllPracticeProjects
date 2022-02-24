using System.Collections.Generic;

namespace Relationships.Database.Entities
{
    public class WorkerCard
    {
        public WorkerCard()
        {
            Claims = new List<Claim>();
        }



        public string Status { get; set; }

        public int Experience { get; set; }

        public List<Claim> Claims { get; set; }
    }
}
