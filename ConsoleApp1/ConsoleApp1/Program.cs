using System;
using System.IO;

namespace Class_test
{
    class SomeClass_1
    {
        public int X = 15;
        public static int operator+(SomeClass_1 class1, SomeClass_2 class2)
        {
            return class1.X + class2.Y;
        }
    }

    class SomeClass_2
    {
        public int Y = 20;
    }

    class Program
    {
        static void Main()
        {
            SomeClass_1 first = new SomeClass_1();
            SomeClass_2 second = new SomeClass_2();

            int res = first + second; // 35
            Console.WriteLine(res);

            Time Data = new Time(10, 55);
            Console.WriteLine(Data);

            Time DataTest = new Time(5, 35);
            Console.WriteLine(DataTest);

            Time DataTestDays = Data - DataTest;
            Console.WriteLine(DataTestDays);

            Time DataK = 2 * DataTestDays;
            Console.WriteLine(DataK);

            DataK = DataTestDays * 2;
            Console.WriteLine(DataK);

            Console.WriteLine(Data > DataTest);

            Time time = new Time(0, 2405);
            Console.WriteLine(time);
        }
    }
}
