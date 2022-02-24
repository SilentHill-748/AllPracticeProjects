using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

namespace FileDatabase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Test> tests;

        public MainWindow()
        {
            InitializeComponent();
            CreateDataContext();
            grid.ItemsSource = tests;
        }

        private void AddRow_Click(object sender, EventArgs e)
        {
            //((List<Test>)grid.ItemsSource).Add(new Test() { Id = 2, FullName = "TestName", Age = 11 });
        }

        private void CreateDataContext()
        {
            tests = new()
            {
                new Test() { Id = "1a", Name = 1, Age = 23 }
                //new Test() { Id = 1, FullName = "Nikita", Age = 23 }
            };
        }
    }

    public class Test
    {
        public int Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }
    }
}
