using System;
using System.Collections;
using System.Collections.Generic;

namespace Structures.Collections
{
    /// <summary>
    ///     Represents a collection that implements the "First In First Out" principle.
    /// </summary>
    public class Queue<T> : IEnumerable<T>, ICloneable
    {
        #region Private fields
        private int _count;

        private Item<T> first;  // tail
        private Item<T> last;   // head
        #endregion

        #region Constructors
        /// <summary>
        ///     Initialize a new <see cref="Queue{T}"/> with default properties.
        /// </summary>
        public Queue()
        {
            first = null;
            last = null;
        }
        #endregion

        #region Properties
        /// <summary>
        ///     Get count of all elements to <see cref="Queue{T}"/>.
        /// </summary>
        public int Count
        {
            get
            {
                _count = 0;
                foreach (T _ in this)
                    _count++;
                return _count;
            }
        }
        #endregion

        #region Public methods
        /// <summary>
        ///     Add object to <see cref="Queue{T}"/>.
        /// </summary>
        /// <param name="data">
        ///     Object which be added to <see cref="Queue{T}"/>.
        /// </param>
        public void Enqueue(T data)
        {
            Item<T> item = new Item<T>(data);

            if (first is null)
            {
                first = item;
                last = item;
            }
            else
            {
                last.Next = item;
                last = item;
            }
        }

        /// <summary>
        ///     Remove and return item from the <see cref="Queue{T}"/>.
        /// </summary>
        /// <returns>
        ///     A object from the <see cref="Queue{T}"/>.
        /// </returns>
        /// <exception cref="NotSupportedException"/>
        public T Dequeue()
        {
            T item;

            if (first is null)
                throw new NotSupportedException("Queue is empty!");
            else
            {
                item = first.Value;
                last = first.Next;
                first = last;
            }
            return item;
        }

        /// <summary>
        ///     Return item from the <see cref="Queue{T}"/>.
        /// </summary>
        /// <returns>
        ///     A object from the <see cref="Queue{T}"/>.
        /// </returns>
        /// <exception cref="NotSupportedException"/>
        public T Peek()
        {
            if (first != null)
                return first.Value;
            else
                throw new NotSupportedException("Queue is empty!");
        }

        /// <summary>
        ///     Clone <see cref="Queue{T}"/> to a new object.
        /// </summary>
        /// <returns>
        ///     A new object which equal <see cref="Queue{T}"/>.
        /// </returns>
        public object Clone()
        {
            return new Queue<T>()
            {
                first = this.first,
                last = this.last,
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            Item<T> current = first;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
        #endregion

        /// <summary>
        ///      Implements <see cref="Queue"/> item.
        /// </summary>
        private class Item<T>
        {
            /// <summary>
            ///     Get current value of item.
            /// </summary>
            public T Value { get; set; }

            /// <summary>
            ///     Get or set next <see cref="Item{T}"/> object.
            /// </summary>
            public Item<T> Next { get; set; }

            /// <summary>
            ///     Initialize a new <see cref="Item{T}"/> with the specified <see cref="Value"/>
            /// </summary>
            /// <param name="data">
            ///     Object which be stored in the <see cref="Item{T}"/>
            /// </param>
            public Item(T data)
            {
                Value = data;
            }
        }
    }
}