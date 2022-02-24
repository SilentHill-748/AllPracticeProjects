using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using Microsoft.Office.Interop.Word;

namespace HoursCounter
{
    class Program
    {
        static TimeSpan allTimes;
        static int skipedDays = 0;
        static int workingDays = 0;

        static void Main()
        {
            Console.Title = "Статистика в часах по файлу отчета";
            try
            {
                Console.Write("Введи название файла (без .docx): ");
                string filename = Console.ReadLine();

                var cells = GetCellsFrom($@"C:\Users\SilentHill\Desktop\{filename}.docx");
                CalculateAllValues(cells);
                GetStatictics();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                KillWordProcess();
                Console.ReadKey();
            }
        }

        static void KillWordProcess()
        {
            foreach (Process proc in Process.GetProcesses())
                if (proc.ProcessName == "WINWORD")
                {
                    proc.Kill();
                    return;
                }
        }

        static List<string> GetCellsFrom(string filename)
        {
            Application app = new Application();
            Document doc = app.Documents.Add(filename);
            Table table = doc.Tables[1];
            var cells = GetCells(table);
            doc.Close();
            return cells;
        }

        static void CalculateAllValues(List<string> tableCells)
        {
            allTimes = GetSumOfAllTimes(tableCells);
            skipedDays = tableCells.Count(m => m.Contains("-"));
            workingDays = tableCells.Count(m => Regex.IsMatch(m, @"\d:\d{2}:\d{2}"));
        }

        static List<string> GetCells(Table table)
        {
            List<string> cells = new List<string>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string item = table.Cell(i, 2).Range.Text;
                cells.Add(item.Replace("\r\a", ""));
            }
            return cells;
        }

        static TimeSpan GetSumOfAllTimes(List<string> tableCells)
        {
            TimeSpan result = new TimeSpan();
            for (var i = 0; i < tableCells.Count; i++)
            {
                if (TimeSpan.TryParse(tableCells[i], out TimeSpan time))
                {
                    result += time;
                }
            }
            return result;
        }

        static void GetStatictics()
        {
            double seconds = allTimes.Ticks / TimeSpan.TicksPerSecond;
            TimeSpan avgTime = TimeSpan.FromSeconds(seconds / DateTime.Now.Day);

            string avgAllTimeResult = $"{avgTime.Hours:D2}:{ avgTime.Minutes:D2}:{ avgTime.Seconds:D2}";

            Console.WriteLine($"\tДанные за {DateTime.Now.MonthOfYear().ToLower()}.");
            Console.WriteLine($"Всего времени затрачено:    {GetAllTime()}");
            Console.WriteLine($"Среднее время в день:       {avgAllTimeResult}");
            Console.WriteLine($"Число пропущенных дней:     {skipedDays}");
            Console.WriteLine($"Число рабочих дней:         {workingDays}");
        }

        static string GetAllTime()
        {
            if (allTimes.Days == 0)
                return $"{allTimes.Hours:D2}:{allTimes.Minutes:D2}:{allTimes.Seconds:D2}";
            int daysInHours = allTimes.Days == 1 ? 24 : allTimes.Days * 24;
            return $"{allTimes.Hours + daysInHours:D2}:{allTimes.Minutes:D2}:{allTimes.Seconds:D2}";
        }

        static TimeSpan GetAvgTimeInWeek()
        {
            double seconds = allTimes.Ticks / TimeSpan.TicksPerSecond;
            int weeks = DateTime.Now.Day / 7;

            if (weeks == 0)
                return allTimes;
            return TimeSpan.FromSeconds(seconds / weeks);
        }
    }
}
