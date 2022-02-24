using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers
{
    public partial class Form1 : Form
    {
        static int mapSize = 8;
        static int cellSize = 100;
        private int[,] map = new int[mapSize, mapSize];
        private int currentPlayer;

        Image whiteFigure;
        Image blackFigure;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
            this.Width = mapSize * (cellSize + 2);
            this.Height = mapSize * (cellSize + 5) + 24;
        }

        private void Init()
        {
            map = new int[,]
            {
                { 0, 2, 0, 2, 0, 2, 0, 2 },
                { 2, 0, 2, 0, 2, 0, 2, 0 },
                { 0, 2, 0, 2, 0, 2, 0, 2 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 0, 1, 0, 1, 0, 1 },
                { 1, 0, 1, 0, 1, 0, 1, 0 },
                { 0, 1, 0, 1, 0, 1, 0, 1 }
            };

            whiteFigure = new Bitmap((new Bitmap(@"e:\Тестовые проекты\Игра шашки\Data\w.png")), new Size(cellSize, cellSize));
            blackFigure = new Bitmap((new Bitmap(@"e:\Тестовые проекты\Игра шашки\Data\b.png")), new Size(cellSize, cellSize));

            CreateMap();
        }

        private void GetColorArea(Button button)
        {
            int i, j;

            for (i = 0; i < mapSize; i++)
                for (j = 0; j < mapSize; j++)
                {
                    // добавить окрас поля в бело-черные тона, как на реальной игровой доске
                }
        }

        private void CreateMap()
        {
            int i, j;

            for ( i = 0; i < mapSize; i++)
                for( j = 0; j < mapSize; j++ )
                {
                    Button cell = new Button
                    {
                        Location = new Point(j * cellSize, 25 + (i * cellSize) ),
                        Size = new Size(cellSize, cellSize)
                    };
                    GetColorArea(cell);
                    cell.Click += new EventHandler(Cell_Click);

                    if (map[i, j] == 1)
                    {
                        cell.BackgroundImageLayout = ImageLayout.Zoom;
                        cell.BackgroundImage = whiteFigure;
                    }
                    if (map[i, j] == 2)
                    {
                        cell.BackgroundImageLayout = ImageLayout.Zoom;
                        cell.BackgroundImage = blackFigure;
                    }

                    this.Controls.Add(cell);
                }
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            Button click = sender as Button;

            if (map[click.Location.Y / cellSize, click.Location.X / cellSize] == 1 ||
                map[click.Location.Y / cellSize, click.Location.X / cellSize] == 2)
                click.BackColor = Color.Purple;
        }
    }
}
