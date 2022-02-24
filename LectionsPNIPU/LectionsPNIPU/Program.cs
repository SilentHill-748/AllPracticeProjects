using System;
using System.CodeDom.Compiler;

namespace LectionsPNIPU
{
    // Задание в тетради.
    public class NumberSystem
    {
        readonly Random rnd = new Random();

        private readonly int defaultSystem = 8;
        private readonly string typeSystemNumber;

        public int Number { get; private set; }
        public int TypeSystem { get; private set; }

        /// <summary>
        /// Работает со случайным числом в случайной системе счисления.
        /// </summary>
        public NumberSystem()
        {
            TypeSystem = defaultSystem;
            Number = rnd.Next(1, int.MaxValue);
        }

        /// <summary>
        /// Работает со случайным числом в выбранной системе счислений.
        /// </summary>
        /// <param name="typeSystem"> Указывает тип системы, с которой производится работа.</param>
        public NumberSystem(int typeSystem)
        {
            try
            {
                CheckTypeSystem(typeSystem);
                TypeSystem = typeSystem;
                this.Number = rnd.Next(1, int.MaxValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Работает с указанным числом в выбранной системе счисления.
        /// </summary>
        /// <param name="typeSystem"> Указывает тип системы, с которой производится работа.</param>
        /// <param name="number"> Число, с которым производятся операции.</param>
        public NumberSystem(int typeSystem, int number)
        {
            try
            {
                CheckTypeSystem(typeSystem);
                TypeSystem = typeSystem;
                this.Number = number;

                typeSystemNumber = ConvertToTypeSystem(typeSystem, number);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// 123
        /// </summary>
        /// <param name="typeSystem"> Указывает тип системы, с которой производится работа.</param>
        /// <param name="typeSystemNumber"> Число, в формате указанной системы счисления.</param>
        public NumberSystem(int typeSystem, string typeSystemNumber)
        {
            try
            {
                // TODO: Проверка указанного числа на соответствие указанной системе.
                CheckTypeSystem(typeSystem);
                TypeSystem = typeSystem;
                this.typeSystemNumber = typeSystemNumber;

                Number = ConvertToNational(typeSystem, typeSystemNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Возвращает сумму десятичных чисел в системе первого члена.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static NumberSystem operator +(NumberSystem num1, NumberSystem num2)
        {
            int temp = num1.Number + num2.Number;
            return new NumberSystem(num1.TypeSystem, temp);
        }

        public static NumberSystem operator -(NumberSystem num1, NumberSystem num2)
        {
            int temp = num1.Number - num2.Number;
            if (temp < 0) temp = 0;

            return new NumberSystem(num1.TypeSystem, temp);
        }

        public static NumberSystem operator *(NumberSystem num1, NumberSystem num2)
        {
            int temp = num1.Number * num2.Number;
            return new NumberSystem(num1.TypeSystem, temp);
        }

        public static NumberSystem operator /(NumberSystem num1, NumberSystem num2)
        {
            int temp;

            try
            {
                temp = num1.Number / num2.Number;
            }
            catch (DivideByZeroException)
            {
                temp = 0;
            }

            return new NumberSystem(num1.TypeSystem, temp);
        }

        public static NumberSystem operator %(NumberSystem num1, NumberSystem num2)
        {
            int temp;

            try
            {
                temp = num1.Number % num2.Number;
            }
            catch (DivideByZeroException)
            {
                temp = 0;
            }
            return new NumberSystem(num1.TypeSystem, temp);
        }

        public static bool operator >(NumberSystem num1, NumberSystem num2)
        {
            if (num1.Number > num2.Number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(NumberSystem num1, NumberSystem num2)
        {
            if (num1.Number < num2.Number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >=(NumberSystem num1, NumberSystem num2)
        {
            if (num1.Number >= num2.Number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <=(NumberSystem num1, NumberSystem num2)
        {
            if (num1.Number <= num2.Number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(NumberSystem num1, NumberSystem num2)
        {
            if (num1.Number == num2.Number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(NumberSystem num1, NumberSystem num2)
        {
            if (num1.Number != num2.Number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int ConvertToNational(int typeSystem, string typeSystemNumber)
        {
            if (!Check(typeSystem, typeSystemNumber)) return 0;

            int result = 0;

            for (int i = 0; i < typeSystemNumber.Length; i++)
            {
                result = result * typeSystem + int.Parse( typeSystemNumber[i].ToString() );
            }

            return result;
        }

        public string ConvertToTypeSystem(int typeSystem, int number)
        {
            string result = "";

            if (number == 0) result = "0";
                    
            while (number != 0)
            {
                result = (number % typeSystem).ToString() + result;
                number /= typeSystem;
            }

            if (!Check(typeSystem, result)) return "0";
            return result;
        }

        /// <summary>
        /// Проверяет, удовлетворяет ли число заявленной системе.
        /// <code></code>
        /// Возврат:
        /// true, если число не заявляет указанной системе или false, если число заявляет указанной системе.
        /// </summary>
        /// <param name="typeSystem"></param>
        /// <param name="typeSystemNumber"></param>
        /// <returns></returns>
        public bool Check(int typeSystem, string typeSystemNumber)
        {
            bool numMore = true;

            if (typeSystemNumber == "") return false;

            for (int i = 0; i < typeSystemNumber.Length; i++)
            {
                if (int.TryParse(typeSystemNumber[i].ToString(), out int res))
                {
                    if (res >= typeSystem)
                    {
                        numMore = false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return numMore;
        }

        public static NumberSystem Pow(NumberSystem foundation, NumberSystem number)
        {
            int typeSystem = foundation.TypeSystem;
            int numberPow = (int)Math.Pow(foundation.Number, number.Number);

            return new NumberSystem(typeSystem, numberPow);
        }

        private void CheckTypeSystem(int type)
        {
            if (type < 2 && type > 9) throw new Exception("Система не поддерживается или не существует.");
        }

        public override string ToString()
        {
            return "Основание: " + TypeSystem.ToString() + "; десятичное число: " + Number.ToString() +
                "; " + TypeSystem.ToString() + "-ичное число: " + typeSystemNumber.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }


    class Program
    {
        static void Sort(int count, ref NumberSystem[] arrayOfSystems)
        {
            NumberSystem temp;

            int k = 0;

            for (int i = 1; k != 0; i++)
            {
                k = 0;
                for (int j = 0; j < count; j++)
                {
                    if (arrayOfSystems[j] < arrayOfSystems[j + 1])
                    {
                        temp = arrayOfSystems[j];
                        arrayOfSystems[j] = arrayOfSystems[j + 1];
                        arrayOfSystems[j+1] = temp;
                        k++;
                    }
                }
            }
        }

        static void Main()
        {
            //NumberSystem sys1 = new NumberSystem(2, 0);
            //NumberSystem sys2 = new NumberSystem(2, "0");
            //NumberSystem sys10 = NumberSystem.Pow(sys1, sys2);

            //Console.WriteLine("Первое число: {0}", sys1);
            //Console.WriteLine("Второе число: {0}", sys2);
            //Console.WriteLine(sys2.Check(5, ""));
            //Console.WriteLine(sys10);

            //Console.WriteLine();

            //NumberSystem sys3 = sys1 + sys2;
            //Console.WriteLine("Сумма: \t\t\t\t{0}", sys3);

            //NumberSystem sys4 = sys1 - sys2;
            //Console.WriteLine("Разность: \t\t\t{0}", sys4);

            //NumberSystem sys5 = sys1 * sys2;
            //Console.WriteLine("Произведение: \t\t\t{0}", sys5);

            //NumberSystem sys6 = sys1 / sys2;
            //Console.WriteLine("Частное: \t\t\t{0}", sys6);

            //NumberSystem sys7 = sys1 % sys2;
            //Console.WriteLine("Остаток от деления: \t\t{0}", sys7);

            //Console.WriteLine();

            //Console.WriteLine(sys1 > sys2);     // true
            //Console.WriteLine(sys1 < sys2);     // false
            //Console.WriteLine(sys1 >= sys2);    // true
            //Console.WriteLine(sys1 <= sys2);    // false
            //Console.WriteLine(sys1 == sys2);    // false
            //Console.WriteLine(sys1 != sys2);    // true
            //Console.WriteLine();

            int n = 5, p;
            NumberSystem[] arrayOfSystems = new NumberSystem[n];
            string str;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                p = int.Parse(Console.ReadLine());
                str = Console.ReadLine();
                arrayOfSystems[i] = new NumberSystem(p, str);
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arrayOfSystems[i]);
            }
            Sort(n, ref arrayOfSystems);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arrayOfSystems[i]);
            }

            Console.ReadLine();
        }
    }
}
