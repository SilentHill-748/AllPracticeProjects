using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestNET5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            test();
        }

        private void test()
        {
            TextBox tb = new TextBox();
            this.Controls.Add(tb);

            tb.Location = new Point(50, 50);
            tb.Text = "Hello world";
        }
    }
}
