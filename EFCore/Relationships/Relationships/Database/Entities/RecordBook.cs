using System;

namespace Relationships.Database.Entities
{
    /// <summary>
    /// Сущность зачётной книжки студента, связь 1:1 со студентом.
    /// </summary>
    public class RecordBook
    {
        public int RecordBookId { get; set; }

        public DateTime EnrollmentDate { get; set; }

        //public int StudentId { get; set; }

        public Student Student { get; set; }
    }
}
