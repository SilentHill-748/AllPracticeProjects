using System;

namespace LabForAslan
{

    /*
    1.	Разработать класс с тремя целочисленными полями. Создать конструктор копирования. 
    Разработать методы, уменьшающие поля в 10 раз. Разработать метод вывода полей. Протестировать все методы.
        
    2.	Разработать класс с одним строковым полем. Создать конструктор копирования. 
    Разработать метод, приписывающий к полю заданную строку. Разработать метод вывода поля. Протестировать все методы.
        
    3.	Разработать класс с одним строковым полем. Создать конструктор копирования. 
    Разработать метод, удаляющий у поля последний символ. Разработать метод вывода поля. Протестировать все методы.
        
    4.	Разработать класс с одним строковым полем. Создать конструктор копирования. 
    Разработать метод, приписывающий к полю заданный символ в начало и конец. Разработать метод вывода поля. 
    Протестировать все методы.
     */

    class SomeClass // 4 задание
    {
        private string someString;

        public SomeClass() //Значение по умолчанию
        {
            someString = "Default";
        }

        public SomeClass(string SomeString)
        {
            someString = SomeString;
        }

        // Методы добавление символа в начало и конец строки и вывода поля
        public void AddChar(char arg)
        {
            someString = arg + someString + arg;
        }

        public override string ToString()
        {
            return someString;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SomeClass test = new SomeClass("Test Message");
            SomeClass test2 = new SomeClass();

            Console.WriteLine(test);
            Console.WriteLine(test2);
            Console.WriteLine();

            test.AddChar('8');
            test.AddChar('7');
            Console.WriteLine(test);
        }
    }
}
