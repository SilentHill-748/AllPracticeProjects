using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticeTimer
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        private DateTime time;

        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        #region Events
        private void Close_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void Hide_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void startLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            timer.Start();
        }

        private void stopLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            timer.Stop();
        }
        #endregion

        #region Private
        private void Init()
        {
            time = new();
            headerLabel.Content = $"{DateTime.Now:dd.MM.yy}";
            InitTimer();
        }

        private void InitTimer()
        {
            timer = new();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 1);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            currentTimerLabel.Content = $"{time:HH:mm:ss}";
            time = time.AddSeconds(1);
        }
        #endregion
    }
}
