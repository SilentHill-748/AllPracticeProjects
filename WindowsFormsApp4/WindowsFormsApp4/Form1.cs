using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using tessnet2;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadText();
        }

        private void ReadText()
        {
            string path = Directory.GetCurrentDirectory() + "\\imagePage.png.tiff";

            Bitmap image = new Bitmap(path);

            string value = "йцукенгшщзхъфывапролджэячсмитьбюЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";
            Tesseract ocr = new Tesseract();
            ocr.SetVariable("tessedit_char_whitelist", value);
            ocr.Init(Directory.GetCurrentDirectory() + "\\tessdate", "rus", false);
            List<Word> words = ocr.DoOCR(image, Rectangle.Empty);

            //_textFromPdfPage.Text = string.Join(" ", words);
        }
    }
}
