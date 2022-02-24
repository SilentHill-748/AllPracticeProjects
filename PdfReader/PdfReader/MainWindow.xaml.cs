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
using Draw = System.Drawing;

using System.IO;

using BitMiracle.Docotic.Pdf;

using Tesseract;

namespace PdfReader
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ReadPage();
            GetAllStringsToTextBlock();
        }

        private void ReadPage()
        {
            string path = @"D:\Кодинг\Проекты C# (VS Community)\Практика и уроки\PdfReader\PdfReader\Пример.pdf";

            using PdfDocument doc = new(path);
            PdfImage? pdfImage = doc.Pages[0].GetImages().FirstOrDefault();
            string? file = pdfImage?.Save("imagePage");

            BitmapImage image = new();
            image.BeginInit();
            image.UriSource = new Uri(Directory.GetCurrentDirectory() + $"\\{file}", UriKind.Absolute);
            image.EndInit();

            _pdfPageScan.Source = image;
        }

        private void GetAllStringsToTextBlock()
        {
            string path = Directory.GetCurrentDirectory() + "\\imagePage.tiff";
            string t = Directory.GetCurrentDirectory() + @"/tessdata";
            TesseractEngine rusEngine = new(
                Directory.GetCurrentDirectory() + @"/tessdata",
                "rus", 
                EngineMode.LstmOnly);
            try
            {
                using Tesseract.Page page = rusEngine.Process(Pix.LoadFromFile(path));
                _textFromPdfPage.Text = page.GetText();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.Message);
            }
        }
    }
}
