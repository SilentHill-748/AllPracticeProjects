using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using Archive.ViewModels;

namespace Archive.Views
{
    public partial class LoadDocuments : Window
    {
        public LoadDocuments()
        {
            InitializeComponent();
            (DataContext as LoadDocumentsViewModel).View = this;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LoadFilesButton_Click(object sender, RoutedEventArgs e)
        {
            LoadFilesButton.IsEnabled = false;
            SelectFilesButton.IsEnabled = false;
            PathToFilesTextBlock.IsEnabled = false;
            CancelButton.IsEnabled = false;
            ProgressBar.Visibility = Visibility.Visible;
        }
    }
}
