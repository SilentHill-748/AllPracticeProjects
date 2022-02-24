using System.Collections.Generic;

namespace Relationships.Database.Entities
{
    /// <summary>
    /// Основная сущность.
    /// </summary>
    public class Student
    {
        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public int Age { get; set; }

        public int RecordBookId { get; set; }

        public RecordBook RecordBook { get; set; }

        public int GroupId { get; set; }

        public Group Group { get; set; }

        public List<Course> Courses { get; set; }

        public List<Enrollment> Enrollments { get; set; }
    }
}
