using System.Collections.Generic;

namespace Relationships.Database.Entities
{
    /// <summary>
    /// Сущность группы, связь со студентом 1:М.
    /// </summary>
    public class Group
    {
        public int GroupId { get; set; }

        public string Code { get; set; }

        public IEnumerable<Student> Students { get; set; }
    }
}
