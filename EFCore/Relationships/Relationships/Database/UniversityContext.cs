using Microsoft.EntityFrameworkCore;

using Relationships.Database.Entities;

using System.Collections.Generic;

namespace Relationships.Database
{
    public class UniversityContext : DbContext
    {
        public UniversityContext() : base() { }



        public DbSet<Course> Courses { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<RecordBook> RecordBooks { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Worker> Workers { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionStr = "Server=localhost;Database=University;User=Silent;Password=Silent748";
            optionsBuilder.UseSqlServer(connectionStr);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecordBook>()
                .Property(rb => rb.EnrollmentDate)
                .HasColumnType("date");

            modelBuilder.Entity<Student>()
                .Property(s => s.StudentId).ValueGeneratedOnAdd();

            modelBuilder.Entity<Student>()
                .HasKey(s => s.StudentId);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.RecordBook)
                .WithOne(rb => rb.Student)
                .HasForeignKey<Student>(s => s.RecordBookId)
                .OnDelete(DeleteBehavior.Restrict);

            // Слияние таблиц со связью 1:1 в 1 таблицу.
            modelBuilder.Entity<User>()
                .HasOne(u => u.UserProfile)
                .WithOne(up => up.User)
                .HasForeignKey<UserProfile>(up => up.UserProfileId);

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<UserProfile>().ToTable("Users");

            // ------------------------------------------------------

            modelBuilder.Entity<Student>()
                .HasOne(student => student.Group)
                .WithMany(group => group.Students);

            modelBuilder.Entity<Group>()
                .Property(g => g.GroupId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Group>()
                .HasKey(g => g.GroupId);

            modelBuilder.Entity<Group>()
                .HasMany(g => g.Students)
                .WithOne(s => s.Group);

            modelBuilder.Entity<RecordBook>()
                .Property(rb => rb.RecordBookId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<RecordBook>()
                .HasKey(rb => rb.RecordBookId);

            modelBuilder.Entity<RecordBook>()
                .HasOne(rb => rb.Student)
                .WithOne(s => s.RecordBook);

            // Садомия с кастомизацией связи M:M... Это сейчас в EF Core 5.0
            modelBuilder.Entity<Student>()
                .HasMany(student => student.Courses)
                .WithMany(course => course.Students)
                .UsingEntity<Enrollment>(
                    enrollmentBuilder => enrollmentBuilder // Enrollments -> Course
                        .HasOne(enrollment => enrollment.Course)
                        .WithMany(course => course.Enrollments)
                        .HasForeignKey(enrollment => enrollment.CourseId),

                    enrollmentBuilder => enrollmentBuilder // Enrollments -> Student
                        .HasOne(enrollment => enrollment.Student)
                        .WithMany(student => student.Enrollments)
                        .HasForeignKey(enrollment => enrollment.StudentId),

                    enrollmentBuilder => // Configuring table 'Enrollments'
                    {
                        enrollmentBuilder.Property(c => c.Mark)
                            .HasColumnType("tinyint")
                            .IsRequired();
                        enrollmentBuilder.Property(c => c.EnrollmentDate)
                            .HasColumnType("date")
                            .HasDefaultValueSql("GETDATE()")
                            .IsRequired();
                        enrollmentBuilder.HasKey(e => new { e.CourseId, e.StudentId });
                        enrollmentBuilder.ToTable("Enrollments");
                    });
            // А как было раньше до 5.0...
            //modelBuilder.Entity<Enrollment>()
            //    .HasOne(e => e.Student)
            //    .WithMany(s => s.Enrollments)
            //    .HasForeignKey();

            //modelBuilder.Entity<Enrollment>()
            //    .HasOne(e => e.Course)
            //    .WithMany(c => c.Enrollments)
            //    .HasForeignKey();

            //modelBuilder.Entity<Enrollment>()
            //    .Property(e => e.EnrollmentDate)
            //    .HasColumnType("date")
            //    .HasDefaultValueSql("GETDATE()");

            //modelBuilder.Entity<Enrollment>()
            //    .Property(e => e.Mark)
            //    .HasColumnType("tinyint")
            //    .IsRequired();

            // Меньше писанины, вроде как, чем выше, но хз... Топорно как-то.
            // Как по мне, вроде так даже лучше по чтению. Если и юзать автогенерацию через EFCore, то тогда вообще ничего не писать 
            // или писать, но в отдельном специальном классе конфигурации.
            modelBuilder.Entity<Worker>().HasKey(w => w.WorkerId);
            modelBuilder.Entity<Worker>()
                .Property(w => w.WorkerId).ValueGeneratedOnAdd();

            modelBuilder.Entity<Worker>()
                .OwnsOne(typeof(WorkerCard), "Card", p =>
                {
                    p.OwnsMany(typeof(Claim), "Claims");
                });
        }
    }
}
