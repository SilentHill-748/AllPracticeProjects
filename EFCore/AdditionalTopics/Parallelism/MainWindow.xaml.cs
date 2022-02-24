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

using Parallelism.Database;
using Parallelism.Database.Models;

using Microsoft.EntityFrameworkCore;

namespace Parallelism
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            AddUsers();
            //TestTimestamp();
        }

        private void AddUsers()
        {
            using UserContext db = new();

            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            db.Profiles.AddRange(new[] {
                new UserProfile() { DateOfEnrollment = DateTime.Now - TimeSpan.FromDays(1) },
                new UserProfile() { DateOfEnrollment = DateTime.Now - TimeSpan.FromDays(100) }
            });

            db.Users.AddRange(new[] {
                new User() { Name = "Bob", Age = 10, UserProfileId = 1 },
                new User() { Name = "Tom", Age = 20, UserProfileId = 2 }
            });
            db.SaveChanges();
        }

        private void TestTimestamp()
        {
            using UserContext db = new();
            User user = db.Users.FirstOrDefault();
            user.Age = 100;
            db.SaveChanges();
        }

        private void testTimestampBut_Click(object sender, RoutedEventArgs e)
        {
            TestTimestamp();
        }
    }
}
