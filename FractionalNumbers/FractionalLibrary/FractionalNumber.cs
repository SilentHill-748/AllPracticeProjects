using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionalLibrary
{
    public class FractionalNumber
    {
        public int Numerator { get; set;}
        public uint Denomimator { get; set; }
        public double Number { get; private set; }

        public FractionalNumber(int numerator, uint denominator)
        {
            if (numerator == 0)  throw new Exception("Числитель не должен быть равны 0!");

            this.Numerator = numerator;
            this.Denomimator = denominator;
            Number = (double)numerator / (double)denominator;
        }

        public FractionalNumber Exponentiation(int degreeNumber)
        {
            if (degreeNumber < 0) throw new Exception("Степень не может быть отрицательным числом!");

            int newNumerator = (int)Math.Pow(this.Numerator, degreeNumber);
            uint newDonominator = (uint)Math.Pow(this.Denomimator, degreeNumber);

            return new FractionalNumber(newNumerator, newDonominator);
        }

        public void Reduction()
        {
            int NOD = SetLeastCommonFactor();
            this.Numerator = Numerator / NOD;
            this.Denomimator = Denomimator / (uint)NOD;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denomimator}";
        }

        public static FractionalNumber operator +(FractionalNumber num1, FractionalNumber num2)
        {
            if (num1.Denomimator == num2.Denomimator)
                return new FractionalNumber(num1.Numerator + num2.Numerator, num1.Denomimator);
            else
            {
                int denom1 = (int)num1.Denomimator;
                int denom2 = (int)num2.Denomimator;
                num1.SetCommonDenomination(denom2);
                num2.SetCommonDenomination(denom1);
                int sumNumer = num1.Numerator + num2.Numerator;

                var temp = new FractionalNumber(sumNumer, num2.Denomimator);
                return temp;
            }
        }

        public static FractionalNumber operator -(FractionalNumber num1, FractionalNumber num2)
        {
            if (num1.Denomimator == num2.Denomimator)
                return new FractionalNumber(num1.Numerator - num2.Numerator, num1.Denomimator);
            else
            {
                int denom1 = (int)num1.Denomimator;
                int denom2 = (int)num2.Denomimator;
                num1.SetCommonDenomination(denom2);
                num2.SetCommonDenomination(denom1);
                int sumNumer = num1.Numerator - num2.Numerator;

                var temp = new FractionalNumber(sumNumer, num2.Denomimator);
                return temp;
            }
        }

        public static FractionalNumber operator *(FractionalNumber num1, FractionalNumber num2)
        {
            int numer = num1.Numerator * num2.Numerator;
            uint denom = num1.Denomimator * num2.Denomimator;

            return new FractionalNumber(numer, denom);
        }

        public static FractionalNumber operator /(FractionalNumber num1, FractionalNumber num2)
        {
            FractionalNumber temp;
            int numer;
            uint denom;
            if (num2.Numerator < 0)
            {
                temp = new FractionalNumber((int)num2.Denomimator, (uint)Math.Abs(num2.Numerator));
                numer = (num1.Numerator * temp.Numerator) * -1;
                denom = num1.Denomimator * temp.Denomimator;
                return new FractionalNumber(numer, denom);
            }
            else
            {
                temp = new FractionalNumber((int)num2.Denomimator, (uint)Math.Abs(num2.Numerator));
                numer = num1.Numerator * temp.Numerator;
                denom = num1.Denomimator * temp.Denomimator;
                return new FractionalNumber(numer, denom);
            }
            
        }

        public static bool operator >(FractionalNumber num1, FractionalNumber num2)
        {
            return num1.Number > num2.Number;
        }

        public static bool operator <(FractionalNumber num1, FractionalNumber num2)
        {
            return num1.Number < num2.Number;
        }

        public static bool operator >=(FractionalNumber num1, FractionalNumber num2)
        {
            return num1.Number >= num2.Number;
        }

        public static bool operator <=(FractionalNumber num1, FractionalNumber num2)
        {
            return num1.Number <= num2.Number;
        }

        public static bool operator ==(FractionalNumber num1, FractionalNumber num2)
        {
            return num1.Number == num2.Number;
        }

        public static bool operator !=(FractionalNumber num1, FractionalNumber num2)
        {
            return num1.Number != num2.Number;
        }

        private void SetCommonDenomination(int secondDenomination)
        {
            checked
            {
                this.Numerator = Numerator * secondDenomination;
                this.Denomimator = Denomimator * (uint)secondDenomination;
            }
        }

        // Алгоритм поиска числа НОД.
        private int SetLeastCommonFactor()
        {
            SetMaxMin(Numerator, (int)Denomimator, out int max, out int min); // Задаем максимум и минимум среди числителя и знаменателя
            int remainder = int.MaxValue;   // Остаток от деления.

            while (remainder > 0) // Делим числа, пока остаток не станет равен 0. Последний делитель - число НОД.
            {
                remainder = max % min; // После деления смещаем числа, чтобы получить вечное деление чисел.
                max = min;
                min = remainder;
            }

            return max;
        }

        private void SetMaxMin(int num1, int num2, out int max, out int min)
        {
            max = num1 > num2 ? num1 : num2;
            min = num1 < num2 ? Math.Abs(num1) : Math.Abs(num2);
        }
    }
}
