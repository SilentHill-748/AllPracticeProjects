using System;
using System.Runtime.InteropServices;

namespace Pointers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Pointers";
            TestIntPointer(748);
            TestStructPointer();
            TestArrayPointer();
        }

        static unsafe void TestIntPointer(int index)
        {
            int* ptr = &index;

            Console.WriteLine($"Address of pointer: {(long)ptr}");
            Console.WriteLine($"Value of pointer: {*ptr}");

            (*ptr)++;
            Console.WriteLine($"Address of incremented pointer: {(long)ptr}");
            Console.WriteLine($"Value of incremented pointer: {*ptr}");
            Console.WriteLine();
        }

        static unsafe void TestStructPointer()
        {
            Point point = new Point();
            Point* ptr = &point;
            ptr->X = 10;
            ptr->Y = 15;

            Console.WriteLine($"Point pointer coordinates: ({ptr->X}; {ptr->Y})");
            Console.WriteLine();
        }

        static unsafe void TestArrayPointer()
        {
            int[] someArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int* array = stackalloc int[someArray.Length];
            fixed (int* arr = &someArray[0])
            {
                for (int i = 0; i < someArray.Length; i++)
                    Console.WriteLine($"{i} element in \"arr\"-pointer: {arr[i]}");
            }
            Console.WriteLine();
        }
    }

    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    // Windows API [page 303]. See "TestWinAPI" project.
    class Win32Iface
    {
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool MoveWindow(IntPtr hWnd, int x, int y, int width, int heigth, bool repaint);
    }
}
