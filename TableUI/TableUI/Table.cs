using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TableUI
{
    public class Table : IEnumerable<object[]>
    {
        private int rowNumber = 0;

        private int[] buffers;
        private string[] headers;           // Заголовки столбцов.
        private List<object[]> rows;        // Строки таблицы.
        private int rowCount;

        public int Count => rows.Count;

        public object[] this[int index]
        {
            get
            {
                if (index > 0 || index < Count)
                    return rows[index];
                else
                    throw new IndexOutOfRangeException();
            }
        }
        
        public Table()
        {
            rows = new List<object[]>();
            headers = new string[] 
            { "Номер", "Номер страницы", "Номер строки", "Текст изменения строки", "Дата изменения" };
            buffers = new int[] { 5, 14, 12, 50, 19 };
            rowCount = headers.Length;
        }

        // Добавление строки.
        public void Add(params object[] values)
        {
            CheckValues(values);
            values = values.Prepend(rowNumber++ + 1).ToArray();     // Добавить в запись её номер.
            values = values.Append(DateTime.Now).ToArray();         // Добавить в запись дату добавления.
            rows.Add(values);
        }

        // Удаление строки по индексу.
        public void RemoveAt(int index)
        {
            var table = FindRows(index+1, "Номер");
            rows.Remove(table[0]);
        }

        // Измнить всю строку.
        public void Edit(int rowIndex, params object[] values)
        {
            int index = rows.IndexOf(FindRows(rowIndex, "Номер").rows[0]);
            CheckValues(values);
            values = values.Prepend(rowIndex).ToArray();    // Добавить в запись её номер.
            values = values.Append(DateTime.Now).ToArray(); // Добавить в запись дату добавления.
            rows[index] = values;
        }

        // Поиск строки по значению.
        public Table FindRows(object value, string columnHeader)
        {
            Table table = new Table();
            int index = IndexOf(columnHeader);

            for (int i = 0; i < Count; i++)
                if (rows[i][index].ToString().Equals(value.ToString()))
                    table.rows.Add(rows[i]);
            return table;
        }

        // Поиск строки с минимальным значением заданного поля.
        public Table FindMinimum(string columnHeader)
        {
            var column = GetColumn(columnHeader);
            object target = column.Min();           // Поиск для строк идет по хэш-коду.
            return FindRows(target, columnHeader);
        }

        public Table FindEmpty()
        {
            Table table = new Table();
            for (int i = 0; i < Count; i++)
                for (int j = 0; j < rowCount; j++)
                {
                    string cell = rows[i][j].ToString();
                    if (string.IsNullOrEmpty(cell))
                        table.rows.Add(rows[i]);
                }
            return table;
        }

        public void Clear()
        {
            rows.Clear();
        }

        // Сортировка коллекции строк.
        public void Sort(string columnHeader)
        {
            int index = IndexOf(columnHeader);
            rows = rows.OrderBy(row => row[index]).ToList();
        }

        // Вернёт строки, соответствующие заданному условию.
        public Table Select(Func<object[], bool> func)
        {
            Table table = new Table();      // Создается таблица
            for (int i = 0; i < Count; i++)
            {
                if (func.Invoke(rows[i]))
                    table.rows.Add(rows[i]);     // Добавляются лишь те записи, которые отвечают условию делегата.
            }
            return table;
        }

        // Выдает массив строк таблицы в формате вывода.
        public string[] GetRows()
        {
            string[] outRows = new string[Count];
            for(int i = 0; i < Count; i++)
                outRows[i] = OutFormat(rows[i]);
            return outRows;
        }

        // Вывод наименований столбов
        public string GetHeaders()
        {
            return OutFormat(headers);
        }

        // Индекс стобца по названию
        public int IndexOf(string columnHeader)
        {
            for (int i = 0; i < headers.Length; i++)
                if (headers[i] == columnHeader)
                    return i;
            return -1;
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            foreach (object[] row in rows)
                yield return row;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private List<object> GetColumn(string columnHeader)
        {
            int index = IndexOf(columnHeader);
            var list = new List<object>();

            if (index == -1) return list;

            for (int i = 0; i < Count; i++)
                list.Add(rows[i][index]);
            return list;
        }

        // Формат вывода таблицы.
        private string OutFormat(object[] values)
        {
            string outStr = "";

            for (int i = 0; i < values.Length; i++)
            {
                string item = values[i].ToString().PadLeft(buffers[i]);
                outStr += $"| {item} ";
                if (i == values.Length - 1) outStr += "|";
            }

            return outStr + "\n"; // В конце добавила символ \n, чтобы курсор перевести на след. строку.
        }

        // Проверка значений.
        private void CheckValues(object[] values)
        {
            if (values.Length != 3) 
                throw new Exception("Числов вводимых данных должно быть равно числу стобцов!");

            CheckBufferInputValue(values);
            CheckItem(values[0], "System.Int32");
            CheckItem(values[1], "System.Int32");
            CheckItem(values[2], "System.String");
        }

        // ПРоверка конкретного значения на указанный тип.
        private void CheckItem(object item, string typeName)
        {
            Type type = Type.GetType(typeName, false, true);
            if (!item.GetType().Equals(type))
                throw new Exception("Введены некорректные данные!");
        }

        private void CheckBufferInputValue(object[] values)
        {
            for (int i = 0; i < values.Length; i++)
                if (values[i].ToString().Length > buffers[i + 1])
                    throw new Exception("Ввод значения, длина символов которого, больше объёма буфера столбца!");
        }
    }
}