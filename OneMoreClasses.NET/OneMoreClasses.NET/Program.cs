using System;

namespace OneMoreClasses.NET
{
    class Reader
    {
        private readonly Lazy<BookLibrary> library = new Lazy<BookLibrary>();

        public void ReadBook()
        {
            library.Value.GetLastAddedBook();
            Console.WriteLine($"Читаем книгу {library.Value.LastNameBook}");
        }

        public void ReadDigitalBook()
        {
            Console.WriteLine("Читаем электронную книгу.");
        }

        public void IsCreatedValue()
        {
            Console.WriteLine(library.IsValueCreated);
        }
    }

    class BookLibrary
    {
        private string lastAddedBook;
        public string LastNameBook
        {
            get
            {
                return lastAddedBook;
            }
        }

        public string[] books = new string[10];
        public string this [int index]
        {
            get
            {
                if (index >= books.Length)
                {
                    throw new Exception("Нет такого элемента в библиотеке.");
                }
                else
                {
                    return books[index];
                }
            }
        }
            
        public BookLibrary() 
        {
            lastAddedBook = "Чехов";
            AddToLibrary(lastAddedBook);
        }

        public BookLibrary(string nameBook)
        {
            this.lastAddedBook = nameBook;
            AddToLibrary(nameBook);
        }

        public void GetLastAddedBook()
        {
            Console.WriteLine($"Выдана книга {lastAddedBook}");
        }

        private void AddToLibrary(string book)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == null)
                {
                    books[i] += book;
                    break;
                }
            }
        }
    }

    interface ITester
    {
        //Span<int> inter;  error
    }

    class SomeClass
    {
        int[] inters = new int[]
        {
            1, 2, 3, 4, 5
        };

        //Span<int> Span = inter; // error

        public void test()
        {
            Span<int> inter = inters; // work

            foreach (int item in inters)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Program
    {
        static readonly Random rnd = new Random();

        static void SetArray(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 101);
            }
        }

        static void GetArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        public static bool FindItem(int number)
        {
            if (number > 5)
                return true;
            else
                return false;
        }

        static void Main()
        {
            Reader reader = new Reader();
            reader.ReadDigitalBook();
            reader.ReadBook();
            reader.IsCreatedValue();

            double x = Math.IEEERemainder(374, 7);
            Console.WriteLine(x);                   // 3

            bool bolean = true;
            double d = Convert.ToDouble(bolean);

            Console.WriteLine(d);

            int[] array = new int[10];
            SetArray(ref array);

            Array.Sort(array);
            GetArray(array);

            int[,,] arr = new int[3, 3, 3];
            Console.WriteLine("Ранк массива arr: " + arr.Rank);        // 3

            Array.Resize<int>(ref array, 15);
            SetArray(ref array);
            Console.WriteLine("Число элементов массива array: " + array.Length); // 15

            int result = Array.BinarySearch(array, 15);
            Console.WriteLine($"result = {result}; Если отрицательное - элемент не найден.");

            int[] newArr = new int[15];
            Array.Copy(array, newArr, array.Length);

            GetArray(array);  // Равен след выводу массива
            GetArray(newArr);

            bool res = Array.Exists<int>(array, new Predicate<int>(FindItem));
            Console.WriteLine(res + " если true - значит в массиве есть число, больше 5.");

            int z = Array.IndexOf(array, 15);
            Console.WriteLine($"Индекс элемента \"15\" = {z}; Если -1 - элемента нет");

            Array.Sort(array);
            Array.Reverse(array);
            GetArray(array);

            string[] countries = new string[]
            {
                "Russia", "USA", "German",
                "China", "Austria", "England",
                "Scotland", "Irish", "Canada"
            };

            Span<string> countriesSpan = countries;

            Span<string> firstTrio = countriesSpan.Slice(0, 3);

            firstTrio.Fill("British");
            Console.WriteLine(firstTrio[firstTrio.Length - 1]); // Fill all Span "British".

            SomeClass sc = new SomeClass();
            sc.test();

            ReadOnlySpan<char> readOnlySpan = new ReadOnlySpan<char>();
            string text = "Hello World";
            readOnlySpan = text.AsSpan().Slice(start: 6, length: 5);

            foreach (char item in readOnlySpan)
            {
                Console.Write($"{item}");
            }
            Console.WriteLine();
        }
    }
}
