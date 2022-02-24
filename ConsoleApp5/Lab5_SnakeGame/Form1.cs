using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_SnakeGame
{
    public partial class Form1 : Form
    {
        private Pen redPen = new Pen(Color.Red, 3);
        private Pen blackPen = new Pen(Color.Black, 2);

        private Graphics graphics;

        private Point startPosition;

        private int y, a, b, c, step = 30;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 477;
            Height = 500;
            startPosition = new Point(477/2, 500 /2);
        }

        // рисует ось координат
        private void button1_Click(object sender, EventArgs e)
        {
            graphics = CreateGraphics();
            graphics.DrawLine(blackPen, Width/2, 0, Width/2, Height);
            graphics.DrawLine(blackPen, 0, Height/2, Width, Height/2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            SetOdds();

            for (int x = 0; x < 2; x++)
            {
                var current = SetPoints(x);
                var next = SetPoints(x + 1);
                graphics.DrawLine(redPen, current.Item1, next.Item1);
                graphics.DrawLine(redPen, current.Item2, next.Item2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private (Point, Point) SetPoints(int x)
        {
            int y = (a * (x * x) + b * x + c) * step;
            x *= step;
            Point p1 = new Point(startPosition.X + x, startPosition.Y - y);
            Point p2 = new Point(startPosition.X - x, startPosition.Y - y);

            return (p1, p2);
        }

        // Задаем значения для x, a, b, c.
        private void SetOdds()
        {
            try
            {
                a = Convert.ToInt32(ATextBox.Text);
                b = Convert.ToInt32(BTextBox.Text);
                c = Convert.ToInt32(CTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
