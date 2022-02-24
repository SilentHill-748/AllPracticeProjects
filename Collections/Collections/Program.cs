using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;

namespace Collections
{
    class Week : IEnumerable
    {
        string[] days = new string[7]
        {
            "Monday", "Tuesday", "Wednesday","Thursday","Friday","Saturday","Sunday"
        };

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < days.Length; i++)
            {
                yield return days[i];
            }
        }
    }

    class Book
    {
        public string Name { get; private set; }

        public Book (string name)
        {
            this.Name = name;
        }
    }

    internal class BookLibrary
    {
        private Book[] books;

        public BookLibrary ()
        {
            books = new Book[]
            {
                new Book("Пушкин"),
                new Book("Лермонтов"),
                new Book("Булгаков"),
                new Book("Чехов")
            };
        }

        public int Length
        {
            get { return books.Length; }
        }

        public IEnumerable GetBooks(int max)
        {
            for (int i = 0; i < max; i++)
            {
                if (i == books.Length)
                {
                    yield break;
                }
                else
                {
                    yield return books[i];
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            BookLibrary lib = new BookLibrary();

            foreach (Book book in lib.GetBooks(10))
            {
                Console.WriteLine(book.Name);
            }

            Week week = new Week();

            foreach(var day in week)
            {
                Console.Write(day + " ");
            }
            Console.WriteLine("\n");

            ObservableCollection<int> numerals = new ObservableCollection<int>();
            numerals.CollectionChanged += Numerals_CollectionChanged;

            numerals.Add(1);
            numerals.Add(2);
            numerals.Remove(1);
            numerals[0] = 10; // Replace 
            numerals.Add(1);
            numerals.Add(2);
            numerals.Add(3);
            numerals.Add(4);

            numerals.Move(0, 4);
            numerals.RemoveAt(4);
            numerals.Clear();
            Console.WriteLine();

            Dictionary<char, string> colors = new Dictionary<char, string>
            {
                ['A'] = "AAA",
                ['B'] = "BBB"
            };

            foreach (var keyValue in colors)
            {
                Console.WriteLine($"{keyValue.Key} - {keyValue.Value}");
            }

            Console.ReadLine();
        }

        private static void Numerals_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch(e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    int newItem = Convert.ToInt32(e.NewItems[0]);
                    Console.WriteLine("Collection added new item - " + newItem);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    int removeItem = Convert.ToInt32(e.OldItems[0]);
                    Console.WriteLine("Removed old item from collection. Item - " + removeItem);
                    break;
                case NotifyCollectionChangedAction.Replace:
                    int OldItem = Convert.ToInt32(e.OldItems[0]);
                    int replacedItem = Convert.ToInt32(e.NewItems[0]);
                    Console.WriteLine($"Old item {OldItem} was replaced on new Item {replacedItem}.");
                    break;
                case NotifyCollectionChangedAction.Move:
                    int oldIndex = Convert.ToInt32(e.OldStartingIndex);
                    int newIndex = Convert.ToInt32(e.NewStartingIndex);
                    int moveItem = Convert.ToInt32(e.OldItems[0]);
                    Console.WriteLine($"Item {moveItem} was moved of {oldIndex} to {newIndex} index by collection."); 
                    break;
                case NotifyCollectionChangedAction.Reset:
                    Console.WriteLine("Collection was cleared.");
                    break;
            }
        }

        static byte Converting(int x)
        {
            return Convert.ToByte(x);
        }

        static void GetNum(int stepen)
        {
            Console.WriteLine(stepen * stepen);
        }

        static void GetList(List<int> list)
        {
            foreach(object item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void GetList(List<byte> list)
        {
            foreach (byte item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void GetLinkedList(LinkedList<int> link)
        {
            foreach(int item in link)
            {
                Console.WriteLine(item);
            }
        }

        static void GetItemsArrayList(ArrayList list)
        {
            foreach(object item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void GetItemsArray(int[] array)
        {
            foreach(int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
