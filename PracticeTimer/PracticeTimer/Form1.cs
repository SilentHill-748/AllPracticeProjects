using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeTimer
{
    public partial class Form1 : Form
    {
        private Timer currentTimer;
        private Timer globalTimer;

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            headerLabel.Text = $"Таймер практики на {DateTime.Now.Date:dd.MM.yy}";
            currentTimerLabel.Text = "";
            globalTimerLabel.Text = "";
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Label lab)
            {
                lab.ForeColor = Color.FromArgb(158, 93, 41);
            }
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label lab)
            {
                lab.ForeColor = Color.Black;
            }
        }

        private void Label_Click(object sender, EventArgs e)
        {

        }
    }
}
