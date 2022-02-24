using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TestWinAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Win32Iface.MoveWindow(this.Handle, 100, 200, 600, 400, true);
        }
    }

    // Windows API [page 303]
    class Win32Iface
    {
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool MoveWindow(IntPtr hWnd, int x, int y, int width, int heigth, bool repaint);
    }
}
