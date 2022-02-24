using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        const int mapSize = 3;
        const int cellSize = 150;
        int[,] map = new int[mapSize, mapSize];
        int countP1 = 0, countP2 = 0;

        int currentPlayer;
        private readonly Image cross;
        private readonly Image zero;

        public Form1()
        {
            InitializeComponent();
            cross = new Bitmap(new Bitmap(@"e:\Тестовые проекты\Крестики-нолики\xx.png"), new Size(cellSize, cellSize));
            zero = new Bitmap(new Bitmap(@"e:\Тестовые проекты\Крестики-нолики\oo.png"), new Size(cellSize, cellSize));
            Init();
            Text = "Tic Tac Toe";
        }

        public void Init()
        {
            currentPlayer = 1;

            map = new int[,]{
                {0, 0, 0 },
                {0, 0, 0 },
                {0, 0, 0 }
            };

            CreateMap();
        }

        public void CreateMap()
        {
            int i, j;

            for (i = 0; i < mapSize; i++)
                for (j = 0; j < mapSize; j++)
                {
                    Button button = new Button
                    {
                        Location = new Point(i * cellSize, j * cellSize),
                        Size = new Size(cellSize, cellSize)
                    };
                    button.Click += new EventHandler(ClickButton);

                    Controls.Add(button);
                }
        }

        public void SwitchPlayer()
        {
            currentPlayer = currentPlayer == 1 ? 2 : 1;
        }

        public void RebootGame()
        {
            while (Controls.Count != 6)
            {
                Controls.RemoveAt(6);
            }

            Init();
            CreateMap();
        }

        public void ClickButton(object sender, EventArgs e)
        {
            Button click = sender as Button;
            switch (currentPlayer)
            {
                case 1:
                    {
                        if (map[click.Location.X / cellSize, click.Location.Y / cellSize] == 0)
                        {
                            map[click.Location.X / cellSize, click.Location.Y / cellSize] = currentPlayer;
                            click.BackgroundImage = cross;
                            SwitchPlayer();
                            CheckWin();
                        }
                    }
                    break;
                case 2:
                    {
                        if (map[click.Location.X / cellSize, click.Location.Y / cellSize] == 0)
                        {
                            map[click.Location.X / cellSize, click.Location.Y / cellSize] = currentPlayer;
                            click.BackgroundImage = zero;
                            SwitchPlayer();
                            CheckWin();
                        }
                    }
                    break;
            }
        }

        public void CheckWin() //проверка на выйгрыш.
        {
            int i, j;

            for(i = 0; i < mapSize; i++) // по вертикали
            {
                for(j = 0; j < mapSize - 2; j++)
                {
                    if(map[i, j] != 0 && map[i, j] == map[i, j + 1] && map[i, j] == map[i,j + 2])
                    {
                        if (map[i, j] == 1)
                        {
                            countP1++;
                            textBox1.Text = countP1.ToString();
                            MessageBox.Show($"Player 1 - won!");
                            RebootGame();
                        }
                        else if (map[i, j] == 2)
                        {
                            countP2++;
                            textBox2.Text = countP2.ToString();
                            MessageBox.Show($"Player 2 - won!");
                            RebootGame();
                        }
                    }
                }
            }

            for(i = 0; i < mapSize - 2; i++) // по горизонтали
            {
                for(j = 0; j < mapSize; j++)
                {
                    if(map[i, j] != 0 && map[i, j] == map[i + 1, j] && map[i, j] == map[i + 2, j])
                    {
                        if (map[i, j] == 1)
                        {
                            countP1++;
                            textBox1.Text = countP1.ToString();
                            MessageBox.Show($"Player 1 - won!");
                            RebootGame();
                        }
                        else if (map[i, j] == 2)
                        {
                            countP2++;
                            textBox2.Text = countP2.ToString();
                            MessageBox.Show($"Player 2 - won!");
                            RebootGame();
                        }
                    }
                }
            }

            for (i = 0; i < mapSize - 2; i++)
                for (j = 0; j < mapSize - 2; j++)
                {
                    if(map[i, j] != 0 && map[i, j] == map[i + 1, j + 1] && map[i, j] == map[i + 2, j + 2])
                    {
                        if (map[i, j] == 1)
                        {
                            countP1++;
                            textBox1.Text = countP1.ToString();
                            MessageBox.Show($"Player 1 - won!");
                            RebootGame();
                        }
                        else if (map[i, j] == 2)
                        {
                            countP2++;
                            textBox2.Text = countP2.ToString();
                            MessageBox.Show($"Player 2 - won!");
                            RebootGame();
                        }
                    }
                }

            if (map[2, 0] != 0 && map[2, 0] == map[1, 1] && map[2, 0] == map[0, 2])
            {
                if (map[2, 0] == 1)
                {
                    countP1++;
                    textBox1.Text = countP1.ToString();
                    MessageBox.Show($"Player 1 - won!");
                    RebootGame();
                }
                else if (map[2, 0] == 2)
                {
                    countP2++;
                    textBox2.Text = countP2.ToString();
                    MessageBox.Show($"Player 2 - won!");
                    RebootGame();
                }
            }

            int count = 0;
            for (i = 0; i < mapSize; i++)
                for (j = 0; j < mapSize; j++)
                {
                    if (map[i, j] != 0)
                        count++;
                    if (count == 9)
                    {
                        MessageBox.Show("Draw!");
                        RebootGame();
                    }
                }
        }

        private void Button1_Click(object sender, EventArgs e) // очищает счет
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
        }
    }
}
