using System;
using System.Text;
using System.Text.RegularExpressions;

namespace WorkToStrings
{
    class Program
    {
        static void Main()
        {
            // C D E F G N P X
            int number = 250;
            double d_number = 12.748789513;
            decimal decNum = 0.48762M;

            Console.WriteLine("{0:C2}", d_number);  // 12.75 $
            Console.WriteLine("{0:D4}", number);    // 0250
            Console.WriteLine("{0:e3}", d_number);  // 1.275е+001
            Console.WriteLine("{0:f4}", d_number);  // 12.7488
            Console.WriteLine("{0:G3}", decNum);    // 0.487
            Console.WriteLine("{0:p}", decNum);     // 48.76%
            Console.WriteLine("{0:X}", number);     // 250 в виде х16 системы счисления

            StringBuilder builder = new StringBuilder("Test string");
            Console.WriteLine(builder.Length);      // 11
            Console.WriteLine(builder.Capacity);    // 16

            builder.Append(3250);
            Console.WriteLine(builder.ToString());                  // Test string3250
            Console.WriteLine("Length - " + builder.Length);        // 15
            Console.WriteLine("Capacity - " + builder.Capacity);    // 16

            builder.Insert(builder.Length, " Hello");       
            Console.WriteLine(builder);                             // Test string3250 Hello

            builder.Replace("3250", "");
            Console.WriteLine(builder);                             // Test string Hello
            Console.WriteLine("Length - " + builder.Length);        // 17
            Console.WriteLine("Capacity - " + builder.Capacity);    // 22

            builder.AppendFormat(" Keks");
            Console.WriteLine(builder);                             // Test string Hello Keks

            builder.Remove(17, 5);
            Console.WriteLine(builder);                             // Test string Hello
            Console.WriteLine();

            string str = "123-456-7890";
            Regex regex1 = new Regex(@"[2\|3]{2}-[0-9]{3}-[0-9]{4}");

            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";// рекомендует майкрофосфт на страницах MSDN

            Console.WriteLine(regex1.Match(str));

            string s = "Бык тупогуб, тупогубенький бычок, у быка губа бела была тупа";
            Regex regex = new Regex(@"\w*губ\w*");

            MatchCollection matches = regex.Matches(s);

            if (matches.Count > 0)
            {
                foreach (Match match in matches) Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("Совпадений не найдено.");
            }
        }
    }
}
