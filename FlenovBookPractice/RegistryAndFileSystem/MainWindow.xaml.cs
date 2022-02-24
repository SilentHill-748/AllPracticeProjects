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
using Microsoft.Win32;

namespace RegistryAndFileSystem
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Test test = new Test();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SavePropBut_Click(object sender, RoutedEventArgs e)
        {
            RegistryKey software = Registry.CurrentUser.CreateSubKey("software");
            RegistryKey myApp = software.CreateSubKey("SilentHill").CreateSubKey("MyApp");
            myApp.SetValue("State", this.WindowState);
            myApp.SetValue("Width", this.Width);
            myApp.SetValue("Height", this.Height);
            myApp.SetValue("Window startup location", this.WindowStartupLocation);
            myApp.SetValue("Test class", test);
            myApp.Close();
        }


    }

    public class Test
    {
        public int X = 10;
    }
}
