using System.Collections.Generic;

namespace Relationships.Database.Entities
{
    /// <summary>
    /// Сущность экзамена, связь М:М со студентами.
    /// </summary>
    public class Course
    {
        public int CourseId { get; set; }

        public string Name { get; set; }

        public List<Student> Students { get; set; }

        public List<Enrollment> Enrollments { get; set; }
    }
}
