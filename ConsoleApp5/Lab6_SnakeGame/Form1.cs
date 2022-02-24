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

namespace Lab6_SnakeGame
{
    public partial class Form1 : Form
    {
        #region --Variables--
        private Random rnd = new Random();  
        private Graphics graph;                 // Объект отрисовки
        private bool[,] gameArea;               // Игровое поле.
        private int resolution;                 // Разрешение игрового поля.
        private int cows;                       // Число клеток в строке.
        private int cols;                       // Число клеток в столбце.
        #endregion

        #region --Properties--

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region --Events--
        private void bStart_Click(object sender, EventArgs e)
        {
            InitArea();
        }

        private void bStop_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        #endregion

        private void InitArea()
        {
            resolution = (int)nudResolution.Value;
            cows = Area.Width / resolution;
            cols = Area.Height / resolution;
            gameArea = new bool[cows, cols];
        }

        private void SetArea()
        {
            for (var i = 0; i < cows; i++)
                for (var j = 0; j < cols; j++)
                    gameArea[i, j] = rnd.Next((int)nudPopulation.Value) == 0;
        }

        private void DrawCells()
        {
            Area.Image = new Bitmap(Area.Width, Area.Height);
            graph = Graphics.FromImage(Area.Image);

            // Отрисовать начальные клетки на поле.
        }
    }
}