using System;

namespace Structures.Collections.Model
{
    internal sealed class Item<T> : IComparable<T>
    {
        private T value = default;

        /// <summary>
        /// Хранит значение элемента коллекции LinkedList.
        /// </summary>
        public T Value
        {
            get => this.value;
            set
            {
                if (value != null)
                    this.value = value;
                else
                    throw new ArgumentNullException();
            }
        }

        public Item<T> Next { get; set; }

        public Item() { }

        public Item(T data) => this.value = data;

        public object Clone()
        {
            return new Item<T>()
            {
                value = value,
                Next = Next,
            };
        }

        public int CompareTo(T other)
        {
            if (other.GetType() != Value.GetType()) throw new Exception();

            if (other.Equals(Value))        
                return 0;

            else if (other is string)       return ToString().CompareTo(other);
            else if (other is char)         return ToString().CompareTo(other);
            else if (other is byte)         return byte.Parse(Value.ToString()).CompareTo(other);
            else if (other is sbyte)        return sbyte.Parse(Value.ToString()).CompareTo(other);
            else if (other is short)        return short.Parse(Value.ToString()).CompareTo(other);
            else if (other is ushort)       return ushort.Parse(Value.ToString()).CompareTo(other);
            else if (other is int)          return int.Parse(Value.ToString()).CompareTo(other);
            else if (other is uint)         return uint.Parse(Value.ToString()).CompareTo(other);
            else if (other is long)         return long.Parse(Value.ToString()).CompareTo(other);
            else if (other is ulong)        return ulong.Parse(Value.ToString()).CompareTo(other);
            else if (other is bool)         return bool.Parse(Value.ToString()).CompareTo(other);
            else if (other is float)        return float.Parse(Value.ToString()).CompareTo(other);
            else if (other is double)       return double.Parse(Value.ToString()).CompareTo(other);
            else         
                return decimal.Parse(Value.ToString()).CompareTo(other);
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
