using System;
using System.Linq;

namespace Lab_2
{
    class Program2
    {
        static string[,] GetArray(int x, int y)
        {
            string[,] map = new string[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (i == 0 || i == x - 1 || j == 0 || j == y - 1) 
                        map[i, j] = "#";
                    else
                        map[i, j] = " ";
                }
            }

            return map;
        }

        static void GeneratePoint(string[,] map, out int x, out int y)
        {
            Random rnd = new Random();

            x = rnd.Next(1, map.GetLength(0) - 1);
            y = rnd.Next(1, map.GetLength(1) - 1);

            map[x, y] = "*";

            ReloadMap(map);
        }

        static void ReloadMap(string[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write($"{map[i, j]}");
                }
                Console.WriteLine();
            }
        }

        static void MoveLeft(string[,] map, ref int x, ref int y)
        {
            int lastY = y;

            if (map[x, y - 1] != "#")
                y -= 1;
            else
                y = map.GetLength(1) - 2;

            //DeleteLastTurn(map, x, lastY);
            map[x, y] = "←";
            map[x, lastY] = " ";

            if (map[x, lastY + 1] == "-") map[x, lastY + 1] = " ";

            if (map[x, lastY + 1] == "#") map[x, 1] = " ";
        }

        static void MoveRight(string[,] map, ref int x, ref int y)
        {
            int lastY = y;

            if (map[x, y + 1] != "#")
                y += 1;
            else
                y = 1;

            //DeleteLastTurn(map, x, lastY);
            map[x, y] = "→";
            map[x, lastY] = " ";
        }

        static void MoveUp(string[,] map, ref int x, ref int y)
        {
            int lastX = x;

            if (map[x - 1, y] != "#")
                x -= 1;
            else
                x = map.GetLength(0) - 2;

            //DeleteLastTurn(map, lastX, y);
            map[x, y] = "↑";
            map[lastX, y] = " ";
        }

        static void MoveDown(string[,] map, ref int x, ref int y)
        {
            int lastX = x;

            if (map[x + 1, y] != "#")
                x += 1;
            else
                x = 1;

            //DeleteLastTurn(map, lastX, y);
            map[x, y] = "↓";
            map[lastX, y] = " ";
        }

        static void Start(string[,] map, ref int x, ref int y)
        {
            while (true)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow: MoveUp(map, ref x, ref y); break;
                    case ConsoleKey.LeftArrow: MoveLeft(map, ref x, ref y); break;
                    case ConsoleKey.DownArrow: MoveDown(map, ref x, ref y); break;
                    case ConsoleKey.RightArrow: MoveRight(map, ref x, ref y); break;
                    case ConsoleKey.Escape: return;
                }

                Console.Clear();
                ReloadMap(map);
            }
        }

        static void Main()
        {
            string[,] map = GetArray(12, 20);
            GeneratePoint(map, out int x, out int y);
            Start(map, ref x, ref y);
        }
    }
}