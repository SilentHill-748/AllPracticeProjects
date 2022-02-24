using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace ДопВозможностиООП
{
    class LocalFunction
    {
        public void Func()
        {
            bool IsMoreThan(int x)
            {
                int limit = 0;
                return x > limit;
            }
        }
    }

    class PatternMatching
    {
        public class Employee
        {
            public virtual void Work()
            {
                Console.WriteLine("Да работаю я, работаю");
            }
        }

        public class Manager : Employee
        {
            public override void Work()
            {
                Console.WriteLine("Отлично, работаем дальше");
            }
            public bool IsOnVacation { get; set; }
        }

        public void UseEmployee(Employee emp)
        {
            if (emp is Manager manager && manager.IsOnVacation == false)
            {
                manager.Work();
            }
            else
            {
                Console.WriteLine("Преобразование не допустимо");
            }
        }
    }

    class AnonimousTypes
    {
        public void Anonimous()
        {
            var type = new { Name = "Test", Age = 15 };
        }
    }

    static class ExtensionsMethods
    {
        public static int CharCount(this string str)
        {
            return str.Length;
        }

        public static void Example()
        {
            string test = "123456789";

            int count = test.CharCount(); // 9
        }
    }

    class Person
    {
        public string Name { get; set; }        // имя пользователя
        public string Status { get; set; }      // статус пользователя
        public string Language { get; set; }    // язык пользователя

        public readonly int age = 15;

        public void Deconstruct(string name, string status, string lang)
        {
            lang = this.Language;
            name = this.Name;
            status = this.Status;
        }
    }

    class NullableTypes
    {
        public void Info()
        {
            // (!) явное преобразование от T? к T
            int? x1 = null;
            if (x1.HasValue)
            {
                int x2 = (int)x1;
                Console.WriteLine(x2);
            }

            // (!) неявное преобразование от T к T?
            int x3 = 4;
            int? x4 = x3;
            Console.WriteLine(x4);

            // (!) неявные расширяющие преобразования от V к T?
            int x5 = 4;
            long? x6 = x5;
            Console.WriteLine(x6);

            // явные сужающие преобразования от V к T?
            long x7 = 4;
            int? x8 = (int?)x7;

            // (!) Подобным образом работают преобразования от V? к T?
            long? x9 = 4;
            int? x10 = (int?)x9;

            // (!) явные преобразования от V? к T
            long? x11 = 4;
            int x12 = (int)x11;
        }
    }

    class Program
    {
        enum Colors
        {
            red,
            blue
        }

        static void Main(string[] args)
        {
            // Локальная переменная-ссылка
            int a = 5;
            int b = 8;
            ref int pointer = ref a;

            pointer = 34;
            pointer = ref b;    // До версии 7.3 так делать было нельзя.
            pointer = 6;

            Console.WriteLine(pointer);
            Console.WriteLine(a);
            Console.WriteLine(b);


            // Ссылка как результат функции.
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            ref int numberRef = ref Find(4, numbers); // ищем число 4 в массиве
            numberRef = 9; // заменяем 4 на 9
            Console.WriteLine(numbers[3]); // 9

            Console.Read();
        }

        static ref int Find(int number, int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    return ref numbers[i]; // возвращаем ссылку на адрес, а не само значение
                }
            }

            // Errors

            //return null;           
            //return ref x;             (const)   
            //return ref Colors.blue;   (enum)
            //return ref pers.Name;     (Property)
            //return ref pers.age;      (Area)

            throw new IndexOutOfRangeException("число не найдено");
        }

        // Pattern properties
        //static string GetMessage(Person p) => p switch
        //{
        //    { Language: "english" } => "Hello!",
        //    { Language: "german", Status: "admin" } => "Hallo!",
        //    { Language: "french" } => "Salut!",
        //    { } => "Hello world!"
        //};

        // Pattern tuples
        /*
         * static string GetWelcome(string lang, string daytime, string status) => (lang, daytime, status) switch
        {
            ("english", "morning", _) => "Good morning",
            ("english", "evening", _) => "Good evening",
            ("german", "morning", _) => "Guten Morgen",
            ("german", "evening", _) => "Guten Abend",
            (_, _, "admin") => "Hello, Admin",
            _ => "Здрасьть"
        };
         */

        // Positional pattern
        /*
         * static string GetWelcome(MessageDetails details) => details switch
        {
            ("english", "morning", _) => "Good morning",
            ("english", "evening", _) => "Good evening",
            ("german", "morning", _) => "Guten Morgen",
            ("german", "evening", _) => "Guten Abend",
            (_, _, "admin") => "Hello, Admin",
            (var lang, var datetime, var status) => $"{lang} not found, {datetime} unknown, {status} undefined",
            _ => "Здрасьть"
        };
         */
    }
}
