using System;
using System.Windows.Forms;

namespace Tourism.Forms
{
    public partial class ShowMessageForm : Form
    {
        public ShowMessageForm(string text, string caption)
        {
            InitializeComponent();

            this.Text = caption;
            FillMessageBox(text);
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillMessageBox(string text)
        {
            string[] info = text.Split('\n');
            messageBox.Lines = info;
            messageBox.BorderStyle = BorderStyle.None;
        }
    }
}
