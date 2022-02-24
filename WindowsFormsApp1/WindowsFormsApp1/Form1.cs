using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "text files (*.txt) | *.txt";
            openFileDialog1.ShowDialog();

            using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
            {
                while (!reader.EndOfStream)
                {
                    string str = reader.ReadLine();
                    richTextBox1.Text += str;
                }
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox2.Font = fontDialog1.Font;

            richTextBox2.Text = richTextBox1.SelectedText;

            using (StreamWriter writer = new StreamWriter(@"D:\NEW TEXT.txt"))
            {
                writer.WriteLine(richTextBox1.SelectedText);
            }
        }
    }
}
