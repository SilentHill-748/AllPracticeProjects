using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExamApp
{
    public class Table
    {
        private int rowCounter = 0;
        public List<object[]> Rows { get; private set; }        // Строки таблицы.
        public int Count => Rows.Count;

        public object this[int index, int column]
        {
            get
            {
                if (index > 0 || index < Count)
                {
                    if (column > 0 || column < Rows[index].Length)
                        return Rows[index][column];
                    else
                        throw new Exception("Такого столбца нет!");
                }
                else
                    throw new Exception("Такой строки нет!");
            }
        }
        
        public Table()
        {
            Rows = new List<object[]>();
        }

        // Добавление строки.
        public void InsertRecord(object[] values)
        {
            if (!CheckValues(values))
                throw new Exception("Неверно введено одно или несколько значений!");
            values = values.Prepend(rowCounter++ +1).ToArray();
            Rows.Add(values);
        }

        // Удаление строки по индексу.
        public void DeleteRecord(int rowIndex)
        {
            Rows.RemoveAt(rowIndex);
        }

        // Измнить всю строку.
        public void EditRecord(int rowIndex, object[] values)
        {
            if (!CheckValues(values))
                throw new Exception("Неверно введено одно или несколько значений!");

            var row = Rows[rowIndex];
            values = values.Prepend(row[0]).ToArray();
            Rows[rowIndex] = values;
        }

        // Поиск строки по значению.
        public Table Search(object value, int columnIndex)
        {
            Table table = new Table();
            for (int i = 0; i < Count; i++)
                if (Rows[i][columnIndex].ToString().Equals(value.ToString()))
                    table.Rows.Add(Rows[i]);

            return table;
        }

        // Поиск строки с минимальным значением заданного поля.
        public Table SearchMin(int columnIndex)
        {
            if (columnIndex == -1)
                throw new Exception("Столбец не найден!");

            List<object> columnItems = new List<object>();  // Собираю коллекцию элементов столбца
            for (int i = 0; i < Count; i++)
                columnItems.Add(Rows[i][columnIndex]);      // Ищу в ней минимальный элемент.

            return Search(columnItems.Min(), columnIndex);   // Вывод таблицы с минимальными значениями столбца.
        }

        // Поиск строк с пустым значением полей.
        public Table SearchEmpty()
        {
            Table table = new Table();
            for (int i = 0; i < Count; i++)
                for (int j = 0; j < Rows[i].Length; j++)
                {
                    string cell = Rows[i][j].ToString();
                    if (string.IsNullOrEmpty(cell))
                        table.Rows.Add(Rows[i]);
                }
            return table;
        }

        public void Clear()
        {
            Rows.Clear();
        }

        // Сортировка коллекции строк.
        public void Sort(int columnIndex)
        {
            if (columnIndex == 4)
            {
                Rows = Rows.OrderBy(r => DateTime.Parse(r[columnIndex].ToString())).ToList();
                return;
            }
            Rows = Rows.OrderBy(r => r[columnIndex]).ToList();
        }

        // Сортирует строки по индексу столбца и указанным условию и значению.
        // Данный метод делает выборку на проверке хэш-кодов элементов.
        // Это значит, что хешь код строки "2" больше хеш-кода строки "2".
        // Поэтому условиям >, <, >=, <= сопоставленый противоположные.
        public Table Select(int columnIndex, string condition, object value)
        {
            Table table = new Table();
            switch (condition)
            {
                case ">": 
                        table.Rows = Rows.Where(
                        r => r[columnIndex].ToString().GetHashCode() < 
                        value.GetHashCode()).ToList(); 
                    break;
                case "<": 
                        table.Rows = Rows.Where(
                        r => r[columnIndex].ToString().GetHashCode() > 
                        value.GetHashCode()).ToList(); 
                    break;
                case ">=": 
                        table.Rows = Rows.Where(
                        r => r[columnIndex].ToString().GetHashCode() <= 
                        value.GetHashCode()).ToList(); 
                    break;
                case "<=": 
                        table.Rows = Rows.Where(
                        r => r[columnIndex].ToString().GetHashCode() >= 
                        value.GetHashCode()).ToList(); 
                    break;
                case "==": 
                        table.Rows = Rows.Where(
                        r => r[columnIndex].ToString().GetHashCode() == 
                        value.GetHashCode()).ToList();
                    break;
                case "!=": 
                        table.Rows = Rows.Where(
                        r => r[columnIndex].ToString().GetHashCode() != 
                        value.GetHashCode()).ToList(); 
                    break;
            }
            return table;
        }

        // Проверка значений.
        private bool CheckValues(object[] values)
        {
            if (values.Length != 5) 
                throw new Exception("Числов вводимых данных должно быть равно 5!");

            string patternFIO = @"[0-9,./<>?;':\[\]{}\-\=_\+!@#№$%^&*()]";
            bool name = Regex.IsMatch(values[0].ToString(), patternFIO);
            bool secName = Regex.IsMatch(values[1].ToString(), patternFIO);
            bool lastName = Regex.IsMatch(values[2].ToString(), patternFIO);
            bool date = DateTime.TryParse(values[3].ToString(), out DateTime time);
            bool address = Regex.IsMatch(values[4].ToString(), @"[,/<>?;':\[\]{}\\=_\+!@#№$%^&*()]");

            return !name && !secName && !lastName && date && !address;
        }
    }
}