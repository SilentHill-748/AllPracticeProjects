using System;

namespace CodeBlogLessons.Structers
{
    /// <summary>
    /// Ячейка списка.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class Item<T>
    {
        private T data = default;

        /// <summary>
        /// Следующая ячейка списка.
        /// </summary>
        public Item<T> Next { get; set; }

        /// <summary>
        /// Данные, хранимые в ячейке списка.
        /// </summary>
        public T Data
        {
            get => data;
            set
            {
                if(value != null)
                {
                    data = value;
                }
                else
                {
                    throw new ArgumentNullException(nameof(value));
                }
            }
        }

        public Item(T data)
        {
            this.Data = data;
        }

        public override string ToString()
        {
            return Data.ToString(); 
        }
    }
}
