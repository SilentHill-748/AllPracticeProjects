using System;

namespace Alg_Lab
{
    class Program
    {
        static string ConvertDoubleToBinary(double a)
        {
            string result = null;
            double dub;
            int Inter;
            
            String[] x = a.ToString().Split(',');
            Inter = int.Parse(x[0]); // конвертим целую часть
            dub = double.Parse($"0,{x[1]}");
            for (int i = 0; i < 5; i++)
            {
                dub = dub * 2;
                if (dub == 1)
                {
                    result += "1";
                    break;
                }
                if (dub > 1)
                {
                    result += "1";
                    dub -= 1;
                }
                else
                    result += "0";
            }

            return ConvertIntToBinary(Inter) + "." + result;
        }
        static string ConvertIntToBinary(int a)
        {
            return Convert.ToString(a, 2);
        }
        static int ConvertBinaryToInt(string s)
        {
            double result = 0;
            int k = s.Length;
            for (int i = 0; i < s.Length; i++)
            {
                if (s.ToCharArray()[i] == '1')
                {
                    k--;
                    result += 1 * Math.Pow(2, k);
                }
                else
                    k--;
            }
            return Convert.ToInt32(result);
        }
        static string ConvertBinaryToString(string Text)
        {
            string[] BinCharArray = new string[9] { "H", "e", "l", "o", "a", "b", "W", "r", "d" };
            string result = null;
            String[] Words = Text.Split(' ');
            foreach (string CharCode in Words)
            {
                switch (CharCode)
                {
                    case "01001000": result += BinCharArray[0]; break;
                    case "01100101": result += BinCharArray[1]; break;
                    case "01101100": result += BinCharArray[2]; break;
                    case "01101111": result += BinCharArray[3]; break;
                    case "01000001": result += BinCharArray[4]; break;
                    case "01000010": result += BinCharArray[5]; break;
                    case "01010111": result += BinCharArray[6]; break;
                    case "01110010": result += BinCharArray[7]; break;
                    case "01100100": result += BinCharArray[8]; break;
                }
            }
            return result;
        }
        static string ConvertStringToBin(string text)
        {
            string[] BinCharArray = new string[9] { "01001000", "01100101", "01101100", "01101111", "01000001", "01000010", "01010111", "01110010", "01100100" };
            string result = null;
            foreach (char CharCode in text)
            {
                switch (CharCode)
                {
                    case 'H': result += BinCharArray[0] + " "; break;
                    case 'e': result += BinCharArray[1] + " "; break;
                    case 'l': result += BinCharArray[2] + " "; break;
                    case 'o': result += BinCharArray[3] + " "; break;
                    case 'a': result += BinCharArray[4] + " "; break;
                    case 'b': result += BinCharArray[5] + " "; break;
                    case 'W': result += BinCharArray[6] + " "; break;
                    case 'r': result += BinCharArray[7] + " "; break;
                    case 'd': result += BinCharArray[8] + " "; break;
                }
            }
            return result;
        }
        static string ConvertBinaryToDouble(string Num)
        {
            String[] Nums = Num.Split('.');

            double result = 0;
            int k = -1;
            for (int i = 0; i < Nums[1].Length; i++)
            {
                if (Nums[1].ToCharArray()[i] == '1')
                {
                    result += Math.Round(1 * Math.Pow(2, k), 10);
                    k--;
                }
                else
                    k--;
            }

            return (ConvertBinaryToInt(Nums[0]) + result).ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ConvertIntToBinary(4));
            Console.WriteLine(ConvertDoubleToBinary(8.4));
            Console.WriteLine(ConvertStringToBin("b"));
        }
    }
}
