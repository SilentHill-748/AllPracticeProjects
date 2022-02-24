using System;
using System.Collections.Generic;

namespace Delegates
{
    class Person
    {
        public string Name { get; set; }
        
        public virtual void Display() => Console.WriteLine($"Person {Name}");
    }

    class Client : Person
    {
        public override void Display() => Console.WriteLine($"Client {Name}");
    }

    class Program
    {
        delegate T Builder<out T>(string name);                 // ковариантный
        delegate void GetInfo<in T>(T item);                    // контравариантный

        static void Main(string[] args)
        {
            Builder<Client> clientBuilder = GetClient;
            Builder<Person> personBuilder1 = clientBuilder;     // ковариантность
            Builder<Person> personBuilder2 = GetClient;         // ковариантность

            Person p = personBuilder1("Tom");               // вызов делегата
            p.Display();                                    // Client: Tom


            GetInfo<Person> personInfo = PersonInfo;
            GetInfo<Client> clientInfo = personInfo;            // контравариантность

            Client client = new Client { Name = "Tom" };
            clientInfo(client); // Client: Tom

            Console.Read();
        }

        private static Person GetPerson(string name)
        {
            return new Person { Name = name };
        }

        private static Client GetClient(string name)
        {
            return new Client { Name = name };
        }

        private static void PersonInfo(Person p) => p.Display();
        private static void ClientInfo(Client cl) => cl.Display();
    }
}
