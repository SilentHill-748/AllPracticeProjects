using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace Archive
{
    public partial class App : Application
    {
        private void Application_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Was throwed unhandled exception!\n\n" + e.Exception.Message + $"\nSender is {sender.GetType().FullName}");
            e.Handled = true;
        }
    }
}
