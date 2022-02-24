using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLife
{
    public partial class Form1 : Form
    {
        GameEngine game;
        Graphics graph;
        Bitmap pixel;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Black;

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // Abstract begin this game.
            game = new GameEngine(4);

            DrawPoint(pictureBox1.Width, pictureBox1.Height, 250, 250);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Abstract end this game.

            // TODO: write end point of game.

            this.Close();
        }

        private void DrawPoint(int x, int y, int wight, int height)
        {
           
        }
    }
}
