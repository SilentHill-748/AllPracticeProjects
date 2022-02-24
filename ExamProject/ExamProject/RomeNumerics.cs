using System;

namespace ExamProject
{
    public class RomeNumerics
    {
        public int IntValue { get; private set; }
        public string Value { get; private set; }

        public RomeNumerics(int number)
        {
            this.IntValue = number;
            this.Value = ToRome();
        }

        public RomeNumerics(string romeNum)
        {
            this.Value = romeNum;
            this.IntValue = FromRome();
        }

        #region Перегрузка операторов
        public static RomeNumerics operator+(RomeNumerics A, RomeNumerics B)
        {
            return new RomeNumerics(A.IntValue + B.IntValue);
        }
        
        public static RomeNumerics operator -(RomeNumerics A, RomeNumerics B)
        {
            if (A.IntValue - B.IntValue < 0)
                throw new Exception("Нельзя вычитать большее из меньшего!");
            return new RomeNumerics(A.IntValue - B.IntValue);
        }
        
        public static RomeNumerics operator *(RomeNumerics A, RomeNumerics B)
        {
            return new RomeNumerics(A.IntValue * B.IntValue);
        }
        
        public static RomeNumerics operator /(RomeNumerics A, RomeNumerics B)
        {
            if (A.IntValue == 0 || B.IntValue == 0)
                throw new Exception("Нельзя делить на 0!");
            return new RomeNumerics(A.IntValue / B.IntValue);
        }

        public static RomeNumerics operator %(RomeNumerics A, RomeNumerics B)
        {
            if (A.IntValue == 0 || B.IntValue == 0)
                throw new Exception("Нельзя делить на 0!");
            return new RomeNumerics(A.IntValue % B.IntValue);
        }

        public static bool operator >(RomeNumerics A, RomeNumerics B)
        {
            return A.IntValue > B.IntValue;
        }

        public static bool operator <(RomeNumerics A, RomeNumerics B)
        {
            return A.IntValue < B.IntValue;
        }

        public static bool operator >=(RomeNumerics A, RomeNumerics B)
        {
            return A.IntValue >= B.IntValue;
        }

        public static bool operator <=(RomeNumerics A, RomeNumerics B)
        {
            return A.IntValue <= B.IntValue;
        }

        public static bool operator ==(RomeNumerics A, RomeNumerics B)
        {
            return A.IntValue == B.IntValue;
        }

        public static bool operator !=(RomeNumerics A, RomeNumerics B)
        {
            return A.IntValue != B.IntValue;
        }
        #endregion

        public override bool Equals(object obj)
        {
            if (obj is RomeNumerics rome)
            {
                return this == rome;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return Value;
        }

        // Преобразует десятичное число в римское.
        private string ToRome()
        {
            if (IntValue == 0) return "";

            if (IntValue < 0)
                throw new InvalidCastException(
                    "Операция преобразования не работает с отрицательными числами!");

            string result = Fill(IntValue);

            return result;
        }

        // Преобразует римское число в десятичное.
        private int FromRome()
        {
            if (string.IsNullOrWhiteSpace(Value))
                return 0;

            int number = 0;
            foreach (char num in Value)
            {
                switch (num)
                {
                    case 'M': number += 1000; break;
                    case 'D': number += 500; break;
                    case 'C': number += 100; break;
                    case 'L': number += 50; break;
                    case 'X': number += 10; break;
                    case 'V': number += 5; break;
                    case 'I': number += 1; break;
                    default:
                        throw new FormatException("Строка с числом имела неверный формат!");
                }
            }
            return number;
        }

        private string Fill(int number)
        {
            string num = "";
            int[] steps = { 1000, 500, 100, 50, 10, 5, 1 };
            char[] chars = { 'M','D','C','L','X','V', 'I' };

            for (int i = 0; i < steps.Length; i++)
            {
                int intParts = number / steps[i];
                for (int j = 0; j < intParts; j++)
                {
                    number -= steps[i];
                    num += chars[i].ToString();
                }
            }
            return num;
        }
    }
}