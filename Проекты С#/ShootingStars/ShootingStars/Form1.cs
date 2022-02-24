using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShootingStars
{
    public partial class Form1 : Form
    {
        public class Star
        {
            public float X { get; set; }
            public float Y { get; set; }
            public float Z { get; set; }
        }

        public Star[] stars = new Star[15000];

        Random rnd = new Random();

        Graphics graph;

        public Form1()
        {
            InitializeComponent();
        }

        private float Map(float n, float start1, float stop1, float start2, float stop2)
        {
            return ((n - start1) / (stop1 - start1)) * (stop2 - start2) + start2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Black;
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            graph = Graphics.FromImage(pictureBox1.Image);
            int i;
            for( i = 0; i < stars.Length; i++ )
            {
                stars[i] = new Star()
                {
                    X = rnd.Next(-pictureBox1.Width, pictureBox1.Width),
                    Y = rnd.Next(-pictureBox1.Height, pictureBox1.Height),
                    Z = rnd.Next(1, pictureBox1.Width),
                };
            }

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            graph.Clear(Color.Black);

            foreach(var star in stars)
            {
                DrawStar(star);
                MoveStar(star);
            }

            pictureBox1.Refresh();
        }

        private void MoveStar(Star star)
        {
            star.Z -= 25;
            if( star.Z < 1 )
            {
                star.X = rnd.Next(-pictureBox1.Width, pictureBox1.Width);
                star.Y = rnd.Next(-pictureBox1.Height, pictureBox1.Height);
                star.Z = rnd.Next(1, pictureBox1.Width);
            }    
        }

        private void DrawStar(Star star)
        {
            float starsize = Map(star.Z, 0, pictureBox1.Width, 8, 0);
            float x = Map(star.X / star.Z, 0, 2, 0, pictureBox1.Width) + pictureBox1.Width / 2;
            float y = Map(star.Y / star.Z, 0, 2, 0, pictureBox1.Height) + pictureBox1.Height / 2;

            graph.FillEllipse(Brushes.Yellow, x, y, starsize, starsize);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
