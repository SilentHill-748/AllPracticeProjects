using System;
using System.Data;
using System.IO;

namespace Class_test
{
    /* Class "Time" (clocks, minutes)
     2 constructions: copy, random pack
     Methods
     1) Summa
     2) Difference
     3) Multiply on number
     4) Comparison on > and <
     5) 
    */
    class Time
    {
        private int hours;
        private int minutes;
        private int days;
        private Random rnd = new Random();

        public Time()
        {
            hours = rnd.Next(0, 24);
            minutes = rnd.Next(0, 60);
            days = 0;
        }

        public Time(int hours, int minutes)
        {
            while(minutes > 59)
            {
                minutes -= 60;
                hours++;

                while (hours > 23)
                {
                    hours -= 24;
                    days += 1;
                }
            }

            this.hours = hours;
            this.minutes = minutes;
        }

        public override string ToString()
        {
            string str = "";
            if(days < 10)
            {
                str += "0";
            }
            str += days.ToString() + ":";

            if (hours < 10)
                str += "0";
            str += hours.ToString() + ":";

            if (minutes < 10)
                str += "0";
            str += minutes.ToString();

            return str;
        }

        public static Time operator +(Time Data, Time Data2)
        {
            int temp = Data.hours * 60 + Data.minutes + Data2.hours * 60 + Data2.minutes;
            return new Time(temp / 60 % 24, temp % 60); // Повтор кода
        }

        public static Time operator -(Time Data, Time Data2)
        {
            int temp = 24 * 60 + Data.hours * 60 + Data.minutes - Data2.hours * 60 - Data2.minutes;
            return new Time(temp / 60 % 24, temp % 60); // Повтор кода
        }

        public static Time operator *(Time Data, int k)
        {
            int temp = (Data.hours * 60 + Data.minutes) * k;
            return new Time(temp / 60 % 24, temp % 60); // Повтор кода
        }

        public static Time operator *(int k, Time Data)
        {
            int temp = (Data.hours * 60 + Data.minutes) * k;
            return new Time(temp / 60 % 24, temp % 60); // Повтор кода
        }

        public static bool operator >(Time Data, Time Data3)
        {
            return Data.hours * 60 + Data.minutes > Data3.hours * 60 + Data3.minutes;
        }

        public static bool operator <(Time Data, Time Data3)
        {
            return Data.hours * 60 + Data.minutes < Data3.hours * 60 + Data3.minutes;
        }
    }
}
