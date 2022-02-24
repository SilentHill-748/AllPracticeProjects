using System;
using System.Collections;
using System.Collections.Generic;

namespace Interface
{
    //interface IAccount
    //{
    //    int CurrentSum { get; }  // Текущая сумма на счету
    //    void Put(int sum);      // Положить деньги на счет
    //    void Withdraw(int sum); // Взять со счета
    //}

    //interface IClient
    //{
    //    string Name { get; set; }
    //}

    //class Client : IAccount, IClient
    //{
    //    int _sum; // Переменная для хранения суммы
    //    public string Name { get; set; }
    //    public Client(string name, int sum)
    //    {
    //        Name = name;
    //        _sum = sum;
    //    }

    //    public int CurrentSum { get { return _sum; } }

    //    public void Put(int sum) { _sum += sum; }

    //    public void Withdraw(int sum)
    //    {
    //        if (_sum >= sum)
    //        {
    //            _sum -= sum;
    //        }
    //    }
    //}



    //interface IAction
    //{
    //    void Move();
    //}

    //class BaseAction : IAction
    //{
    //    void IAction.Move()
    //    {
    //        Console.WriteLine("Move in Base Class");
    //    }
    //}




    //interface ISchool
    //{
    //    void Study();
    //}

    //interface IUniversity
    //{
    //    void Study();
    //}

    //class Person : ISchool, IUniversity
    //{
    //    void ISchool.Study()
    //    {
    //        Console.WriteLine("Учеба в школе");
    //    }

    //    void IUniversity.Study()
    //    {
    //        Console.WriteLine("Учеба в университете");
    //    }
    //}



    // Реализация интерфейсов в базовых и производных классах. Изменение реализации интерфейсов в производных классах.
    //interface IAction
    //{
    //    void Move();
    //}

    //class BaseAction : IAction
    //{
    //    public void Move()
    //    {
    //        Console.WriteLine("Move in BaseAction");
    //    }
    //}

    //class HeroAction : BaseAction, IAction
    //{
    //    public new void Move()
    //    {
    //        Console.WriteLine("Move in HeroAction");
    //    }

    //    void IAction.Move()
    //    {
    //        Console.WriteLine("Move in IAction");
    //    }
    //}


    // Наследование интерфейсов
    //interface IAction
    //{
    //    void Move();
    //}

    //interface IRunAction : IAction
    //{
    //    void Run();
    //}

    //class BaseAction : IRunAction
    //{
    //    public void Move()
    //    {

    //    }

    //    public void Run()
    //    {

    //    }
    //}



    //// Интерфейсы в обобщениях.
    //interface IAccount
    //{
    //    int CurrentSum { get; } // Текущая сумма на счету
    //    void Put(int sum);      // Положить деньги на счет
    //    void Withdraw(int sum); // Взять со счета
    //}

    //interface IClient
    //{
    //    string Name { get; set; }
    //}

    //class Client : IAccount, IClient
    //{
    //    int _sum; // Переменная для хранения суммы

    //    public Client(string name, int sum)
    //    {
    //        Name = name;
    //        _sum = sum;
    //    }

    //    public string Name { get; set; }

    //    public int CurrentSum
    //    {
    //        get { return _sum; }
    //    }

    //    public void Put(int sum)
    //    {
    //        _sum += sum;
    //    }

    //    public void Withdraw(int sum)
    //    {
    //        if (sum <= _sum)
    //        {
    //            _sum -= sum;
    //        }
    //    }
    //}

    //class Transaction<T> where T : IAccount, IClient
    //{
    //    public void Operate(T acc1, T acc2, int sum)
    //    {
    //        if (acc1.CurrentSum >= sum)
    //        {
    //            acc1.Withdraw(sum);
    //            acc2.Put(sum);
    //            Console.WriteLine($"{acc1.Name} : {acc1.CurrentSum}\n{acc2.Name} : {acc2.CurrentSum}");
    //        }
    //    }
    //}

    //// Обобщенные интерфейсы.
    //interface IUser<T>
    //{
    //    T Id { get; }
    //}

    //class User<T> : IUser<T>
    //{
    //    T _id;

    //    public User(T id)
    //    {
    //        _id = id;
    //    }

    //    public T Id { get { return _id; } }
    //}



    //class Person : IComparable<Person>
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }

    //    public int CompareTo(Person p)
    //    {
    //         return this.Name.CompareTo(p.Name);
    //    }
    //}

    //class PeopleComparer : IComparer<Person>
    //{
    //    public int Compare(Person p1, Person p2)
    //    {
    //        if (p1.Name.Length > p2.Name.Length)
    //        {
    //            return 1;
    //        }
    //        else if (p1.Name.Length < p2.Name.Length)
    //        {
    //            return -1;
    //        }
    //        else
    //        {
    //            return 0;
    //        }
    //    }
    //}

    // Инвариантность, ковариантность и контравариантность обобщенных интерфейсов.
    interface IBank<out T> // Ковариантный
    {
        T CreateAccount(int sum);
    }

    class Bank<T> : IBank<T> where T : Account, new()
    {
        public T CreateAccount(int sum)
        {
            T acc = new T();  // создаем счет
            acc.DoTransfer(sum);
            return acc;
        }
    }

    interface ITransaction<in T>
    {
        void DoOperation(T account, int sum);
    }

    class Transaction<T> : ITransaction<T> where T : Account
    {
        public void DoOperation(T account, int sum)
        {
            account.DoTransfer(sum);
        }
    }

    class Account
    {
        public virtual void DoTransfer(int sum)
        {
            Console.WriteLine($"Клиент положил на счет {sum} долларов");
        }
    }

    class DepositAccount : Account
    {
        public override void DoTransfer(int sum)
        {
            Console.WriteLine($"Клиент положил на депозитный счет {sum} долларов");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Все объекты Client являются объектами IAccount 
            //IAccount account = new Client("Том", 200);
            //account.Put(200);
            //Console.WriteLine(account.CurrentSum); // 400
            // Не все объекты IAccount являются объектами Client, необходимо явное приведение
            //Client client = (Client)account;

            // Интерфейс IAccount не имеет свойства Name, необходимо явное приведение
            //string clientName = ((Client)account).Name;



            // Явная реализация интерфейсов
            // Следует учитывать, что при явной реализации интерфейса его методы и 
            // свойства не являются частью интерфейса класса

            //BaseAction action = new BaseAction();
            //((IAction)action).Move();   // необходимо приведение к типу IAction

            // или так
            //IAction action2 = new BaseAction();
            //action2.Move();




            //Person p = new Person();

            //((ISchool)p).Study();
            //((IUniversity)p).Study();


            //BaseAction action1 = new BaseAction();
            //action1.Move();                         // Реализация BaseAction

            //HeroAction action2 = new HeroAction();
            //action2.Move();                         // Реализация HeroAction

            //IAction action3 = new HeroAction();
            //action3.Move();                         // Реализация HeroAction



            //// Интерфейсы в обобщениях.
            //Client account1 = new Client("Tom", 200);
            //Client account2 = new Client("Bob", 300);
            //Transaction<Client> transaction = new Transaction<Client>();
            //transaction.Operate(account1, account2, 150);

            //// Обобщенные интерфейсы.
            //IUser<int> user1 = new User<int>(6789);
            //Console.WriteLine(user1.Id);              // 6789

            //IUser<string> user2 = new User<string>("12345");
            //Console.WriteLine(user2.Id);              // 12345



            //// Копирование объектов. Интерфейс ICloneable.
            //Person pers1 = new Person { Name = "Tom", Age = 45, Work = new Company { Name = "Apple" } };
            //Person pers2 = (Person)pers1.Clone();

            //pers1.Work.Name = "Microsoft";
            //pers2.Name = "Den";

            //Console.WriteLine(pers1.Work.Name);
            //Console.WriteLine(pers2.Work.Name);

            // IComparable<in T> and IComparer<in T>
            //Person p1 = new Person { Name = "AAA", Age = 33 };
            //Person p2 = new Person { Name = "AA", Age = 44 };
            //Person p3 = new Person { Name = "A", Age = 55 };

            //Person[] people = new Person[] { p1, p2, p3 };

            //Array.Sort(people, new PeopleComparer());

            //foreach(Person pers in people)
            //{
            //    Console.WriteLine($"{pers.Name} - {pers.Age}");
            //}



            // Инвариантность, ковариантность и контравариантность обобщенных интерфейсов.
            IBank<DepositAccount> depositBank = new Bank<DepositAccount>();
            Account account = depositBank.CreateAccount(34);

            IBank<Account> acc2 = depositBank;
            Account account1 = acc2.CreateAccount(87);


            ITransaction<Account> transaction = new Transaction<Account>();
            transaction.DoOperation(new Account(), 250);

            ITransaction<DepositAccount> depositTransaction = new Transaction<Account>();
            depositTransaction.DoOperation(new DepositAccount(), 450);

            Console.ReadKey();
        }
    }
}
