using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using MyFirstUwpApp.Model;
using Windows.UI.Popups;

namespace MyFirstUwpApp
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Person Data = new Person();

        public MainPage()
        {
            this.InitializeComponent();
            Data.FirstName = "Никита";
            Data.LastName = "Палин";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog messageDialog = new MessageDialog(Data.FirstName, "Пидор");
            messageDialog.ShowAsync().AsTask();
        }
    }
}
