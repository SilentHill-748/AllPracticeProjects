using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;

namespace NUnitTestingTable
{
    class Program
    {
        static void GetTable(Table table)
        {
            Console.WriteLine(table.GetColumns());

            foreach (Record record in table.Records)
                Console.WriteLine(record.ToString());
        }

        static void Main(string[] args)
        {
            Table t1 = new Table();
            t1.InsertRecord('М', "Иван", "Колосов", 8);
            t1.InsertRecord('М', "Олег", "Бобров", 4);

            Table t2 = new Table();
            t2.InsertRecord('М', "Петр", "Ласков", 2);
            t2.InsertRecord('М', "Алексей", "Харьков", 5);

            t1.AddTable(t2);

            Table expected = new Table();
            expected.InsertRecord('М', "Иван", "Колосов", 8);
            expected.InsertRecord('М', "Олег", "Бобров", 4);
            expected.InsertRecord('М', "Петр", "Ласков", 2);
            expected.InsertRecord('М', "Алексей", "Харьков", 5);

            GetTable(t1);
            Console.WriteLine();

            GetTable(expected);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
