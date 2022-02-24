using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Relationships.Database;
using Relationships.Database.Entities;

using Microsoft.EntityFrameworkCore;

namespace Relationships
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadDataToDatabase();

            //OneToOneRelantionship();
            //ManyToManyRelationship1();
            //ManyToManyRelationship2();
            //ReadDataFromMxMRelationship();


        }

        private void LoadDataToDatabase()
        {
            using UniversityContext db = new();

            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            Group[] groups = new Group[]
            {
                new() { Code = "ЭВТ19" },
                new() { Code = "ПГС18" }
            };
            db.Groups.AddRange(groups);

            Student[] students = new Student[]
            {
                new() { FirstName = "Никита", GroupId = 1, Age = 23, RecordBookId = 1 },
                new() { FirstName = "Антон", GroupId = 1, Age = 21, RecordBookId = 2 },
                new() { FirstName = "Слава", GroupId = 2, Age = 24, RecordBookId = 3 },
                new() { FirstName = "Глеб", GroupId = 1, Age = 25, RecordBookId = 4 }
            };
            db.Students.AddRange(students);

            RecordBook[] books = new RecordBook[]
            {
                new() { EnrollmentDate = DateTime.Now.Date },
                new() { EnrollmentDate = DateTime.Now.Date },
                new() { EnrollmentDate = DateTime.Now.Date },
                new() { EnrollmentDate = DateTime.Now.Date }
            };
            db.RecordBooks.AddRange(books);

            db.Courses.AddRange(new Course[] {
                new Course() { Name = "Программирование", Students = students[0..2].ToList() },
                new Course() { Name = "Моделирование", Students = students[2..4].ToList() }
            });

            List<Claim> claims = new()
            {
                new Claim() { SomeProperty = "123" },
                new Claim() { SomeProperty = "123" },
                new Claim() { SomeProperty = "123" }
            };

            db.Workers.AddRange(new Worker[] {
                new Worker("Никита", 25, new WorkerCard() { Status = "Worked", Experience = 10, Claims = claims }),
                new Worker("Олег", 21, new WorkerCard() { Status = "Worked", Experience = 5, Claims = claims }),
                new Worker("Бобырь", 28, new WorkerCard() { Status = "Fired", Experience = 8, Claims = claims })
            });

            db.SaveChanges();
        }

        private void EagerLoading()
        {
            _someTextBlock.Text = "";
            using UniversityContext context = new();

            List<Student> allStuds = context.Students
                .Include(s => s.Group)
                .Include(s => s.RecordBook)
                .ToList();

            foreach (Student student in allStuds)
            {
                _someTextBlock.Text += $"Студент: {student.FirstName}, {student.Age}, {student.Group?.Code}" +
                    $"\nДата зачисления: {student.RecordBook?.EnrollmentDate.ToShortDateString()}\n\n";
            }
        }

        private void ExplicitLoading()
        {
            _someTextBlock.Text = "";
            using UniversityContext db = new();

            Group pgs18 = db.Groups.Where(g => g.Code == "ПГС18").FirstOrDefault();
            Student student = db.Students.Where(s => s.FirstName == "Никита").FirstOrDefault();
            //db.Students
            //    .Where(s => s.Group.GroupId == pgs18.GroupId).Load();

            // Collection, Reference
            db.Entry(pgs18).Collection(g => g.Students).Load();
            db.Entry(student).Reference(s => s.RecordBook).Load();

            foreach (Student s in pgs18.Students)
            {
                _someTextBlock.Text += $"Студент: {student.FirstName}\nПоступил: {student.RecordBook.EnrollmentDate.ToShortDateString()}\n";
                _someTextBlock.Text += $"Группа: {pgs18.Code}\n" +
                    $"Студент: {s.FirstName}\n\n";
            }
        }

        //Не актуально.
        private void LazyLoading()
        {
            _someTextBlock.Text = "";
            using UniversityContext db = new();

            var students = db.Students.ToList();
            foreach (Student s in students)
            {
                _someTextBlock.Text += $"Группа: {s.Group.Code}\n" +
                    $"Данные студента: {s.FirstName}, {s.Age}\n" +
                    $"Поступил: {s.RecordBook.EnrollmentDate.ToShortDateString()}\n" +
                    $"------------------------------------------------\n";
            }
        }

        // 1:1
        private void OneToOneRelantionship()
        {
            using UniversityContext db = new();
            Student student = db.Students.FirstOrDefault(s => s.FirstName == "Никита");
            db.Students.Remove(student);

            db.SaveChanges();
        }

        // M:M
        private void ManyToManyRelationship1()
        {
            using UniversityContext db = new();

            Student slava = db.Students
                .Include(s => s.Courses)
                .FirstOrDefault(s => s.FirstName == "Слава");

            Course modeling = slava.Courses.FirstOrDefault(c => c.Name == "Моделирование");
            Course algorithms = new()
            {
                Name = "Алгоритмы",
                Students = new List<Student> { slava }
            };

            db.Courses.Add(algorithms);
            slava.Courses.Remove(modeling);

            db.Students.Update(slava);
            db.SaveChanges();
        }

        private void ManyToManyRelationship2()
        {
            using UniversityContext db = new();

            List<RecordBook> rb = new()
            {
                new RecordBook() { EnrollmentDate = DateTime.Now },
                new RecordBook() { EnrollmentDate = DateTime.Now }
            };
            db.RecordBooks.AddRange(rb);

            List<Student> bobAndBill = new()
            {
                new Student() { FirstName = "Bob", Age = 25, GroupId = 1, RecordBookId = 5, Enrollments = new() },
                new Student() { FirstName = "Bill", Age = 24, GroupId = 1, RecordBookId = 6, Enrollments = new() }
            };
            db.Students.AddRange(bobAndBill);

            List<Course> courses = new()
            {
                new Course() { Name = "Философия" },
                new Course() { Name = "Музыка" }
            };
            db.Courses.AddRange(courses);

            bobAndBill[0].Enrollments.Add(new Enrollment() { Course = courses[0], EnrollmentDate = DateTime.Now, Mark = 4 });
            bobAndBill[1].Enrollments.Add(new Enrollment() { Course = courses[1], EnrollmentDate = DateTime.Now, Mark = 5 });

            db.SaveChanges();
        }

        private void ReadDataFromMxMRelationship()
        {
            using UniversityContext db = new();

            //Select
            // Найти всех студентов группы ЭВТ19, которые подписаны на курсы программирования.
            Group evt = db.Groups.FirstOrDefault(g => g.Code == "ЭВТ19");
            Course course = db.Courses.FirstOrDefault(c => c.Name == "Программирование");

            var students = db.Students
                .Include(s => s.Enrollments)
                    .ThenInclude(s => s.Course)
                .Where(s => s.Group.GroupId == evt.GroupId && s.Courses.Contains(course))
                .ToList();

            foreach (Student s in students)
            {
                _someTextBlock.Text += $"Студент: {s.FirstName}.\nСписок курсов:";
                foreach (Course c in s.Courses)
                {
                    _someTextBlock.Text += $"\n{c.Name}";
                }
                _someTextBlock.Text += "\n\n";
            }

            //Update
            //Изменить у студента "Глеб" группу на ПГС18 и удалить курс моделирования + добавить 2 курса
            // 'Программирования' и 'Алгоритмы'.
            List<Course> courses = db.Courses
                .Where(c => c.Name == "Алгоритмы" || c.Name == "Программирование")
                .ToList();

            Student gleb = db.Students
                .Include(s => s.Courses)
                .FirstOrDefault(s => s.FirstName == "Глеб");

            Group pgs = db.Groups.FirstOrDefault(g => g.Code == "ПГС18");

            gleb.Courses = courses;
            gleb.Group = pgs;

            db.SaveChanges();
        }



        // Tests
        private void EagerLoadingBut_Click(object sender, RoutedEventArgs e)
        {
            EagerLoading();
        }

        private void ExplicitLoadBut_Click(object sender, RoutedEventArgs e)
        {
            ExplicitLoading();
        }

        private void LazyLoadBut_Click(object sender, RoutedEventArgs e)
        {
            //LazyLoading();
        }
    }
}
