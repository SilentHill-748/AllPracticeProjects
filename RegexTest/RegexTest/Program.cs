using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace RegexTest
{
    class Program
    {
        static void SetData(MatchCollection collection, out uint id, out string name, out char sex)
        { 
            id = Convert.ToUInt32(collection[0].Value);
            name = collection[1].Value.ToString();
            sex = Convert.ToChar(collection[2].Value);
        }

        static void EditRecord(string quary, out uint id, out string name, out char sex)
        {
            string temp = "SET VALUE";

            if (quary.StartsWith(temp))
                quary = quary.Remove(0, temp.Length);
            else
                throw new Exception("Syntax error.");

            Regex pattern = new Regex(@"[0-9a-zа-я]\w*", RegexOptions.IgnoreCase);
            MatchCollection matches = pattern.Matches(quary);

            SetData(matches, out id, out name, out sex);
        }

        static void Main()
        {
            // & - Логическое умножение         (101(5) & 010(2) = 000(0))
            // | - ЛОгическое сложение          (101(5) | 010(2) = 111(7))
            // ^ - XOR. True, когда 1^0 или 0^1 (101(5) ^ 011(3) = 110(6))
            // ~ - Инверсия.                    (~00000101(5)    = 11111010(-6))

            //int x = 45;     // 0101101
            //int key = 102;  // 1100110

            //int encript = x ^ key;
            //Console.WriteLine("Зашифрованное число: " + encript);   // 1001011 = 75

            //int decript = encript ^ key;
            //Console.WriteLine("Расшифрованное число: " + decript);  // 1001011^1100110 = 0101101 = 45

            //Console.WriteLine(~decript);                            // 1010010 = -46

            //x = 0b101;
            //x = x << 3;
            //Console.WriteLine(x == 0b101000); // true

            string input;

            Console.Write("Введите запрос: ");
            input = Console.ReadLine();

            EditRecord(input, out uint id, out string name, out char sex);

            Console.WriteLine("Номер |      Имя | Пол");
            Console.WriteLine($"{id}".PadLeft(5) + " | " + $"{name}".PadLeft(8) + " | " + $"{sex}".PadLeft(3));

            Console.ReadLine();
        }
    }
}
