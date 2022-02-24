using System;

namespace ConsoleTable
{
    public class ConsoleTable
    {
        // ConsoleColor отвечает за цвета текста и фона в консоли.
        private ConsoleColor _textColor;                                // Задаю переменную для хранения цвета текста.
        private ConsoleColor _backgroundColor;                          // Задаю переменную для хранения цвета фона текста.

        private object[][] records;                                     // Для решения использую зубчатый массив. В нем буду хранить массивы значений каждой записи.

        private string[] columns;                                       // Для хранения столбцов.
        private string _tableName;                                      // Название таблицы.
        private static int counterOfrecords = 0;

        public string TableName { get => _tableName; }                  // Задаю свойство, которое будет показывать название таблицы.
        public int Count { get => records.Length; }                     // Задаю свойство, которое будет давать понятие о том, сколько вмещает записей таблица.
        public ConsoleColor TextColor { get => _textColor; }            // Задаю свойства, по которым можно узнать текущие цвета объекта (таблицы).
        public ConsoleColor Background { get => _backgroundColor; }

        public ConsoleTable(string tableName, uint countOfRecords, ConsoleColor textColor, ConsoleColor background, params string[] columns)
        {
            records = new object[countOfRecords][];
            this._textColor = textColor;
            this._backgroundColor = background;
            this.columns = columns;
            this._tableName = tableName;
        }

        // Вставить запись в таблицу.
        public void InsertRecord(params object[] values)
        {
            if (counterOfrecords >= Count)                  // Если новая вводимая строка по счету будет больше прописанной длины
            {
                Console.WriteLine("Таблица заполнена!");    // Выдам сообщение, что таблица заполнена
                return;                                     // И выйду из метода.
            }
            else
            {
                if (!CheckValues(values)) return;           // Проверка введенных значений.
                AddValues(values);                          // Добавление в таблицу введенных значений, если проверка пройдена.
                counterOfrecords++;                         // Инкрементирую счетчик записей, добавленных в таблицу.
            }
        }

        // Выводит все столбцы в консоль.
        public void GetColumns()
        {
            SetColors();                                // Задаю цветовые настройки для корректного вывода наименований столбцов
            Console.WriteLine(FormatOutput(columns));   // Вывод строки с названием каждого столбца.
            GotToDefaultColors();                       // Возвращаю первоначальные настройки цветов.
        }

        // Выводит все хранящиеся в таблице записи.
        public void GetTable()
        {
            SetColors();
            for (int i = 0; i < counterOfrecords; i++)
                Console.WriteLine(FormatOutput(records[i]));    // Вывожу каждую строку в консоль по определенному формату.
            GotToDefaultColors();
        }

        private void GotToDefaultColors()
        {
            Console.BackgroundColor = default;
            Console.ForegroundColor = ConsoleColor.White;
        }

        // Применяю указанные цвета для консоли.
        private void SetColors()
        {
            Console.BackgroundColor = _backgroundColor; // Задаю фон текста.
            Console.ForegroundColor = _textColor;       // Задаю цвет текста.
        }

        // Задает формат вывода для каждой записи.
        private string FormatOutput(object[] values)
        {
            int buffer = 15;                                        // Буфер, который служит, как граница строки в столбце.
            string output = "";

            for (int i = 0; i < values.Length; i++)
            {
                output += values[i].ToString().PadRight(buffer);    // PadRight - заполняет пробелами правую часть строки до указанной общей длинны (buffer).
                if (i < values.Length - 1) output += " | ";         // Ставлю разделители для каждого столбца, кроме последнего.
            }
            return output;
        }

        // Проверяю количество введенных значений в массиве values и возвращаю false, если их недостаточно по числу столбцов, иначе true.
        private bool CheckValues(object[] values)
        {
            if (values.Length != columns.Length)
            {
                Console.WriteLine($"Введено менее или более значений, чем {columns.Length}!");  // При попытке вставить запись в заполненную таблицу выдаст сообщение и вернет false.
                return false;
            }
            else
                return true;
        }

        // Добавление записи в зубчатый массив. Инфа по ним: https://metanit.com/sharp/tutorial/2.4.php
        private void AddValues(object[] values) => records[counterOfrecords] = values;        
    }
}
