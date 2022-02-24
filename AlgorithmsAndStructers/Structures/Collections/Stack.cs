using System;
using System.Collections;
using System.Collections.Generic;

namespace Structures.Collections
{
    /// <summary>
    ///     Represents a collection that implements the "Last In First Out" principle.
    /// </summary>
    public class Stack<T> : IEnumerable<T>, ICloneable
    {
        #region Private fields
        private int _count;

        private Item<T> last;   // tail
        private Item<T> first;  // head
        #endregion

        #region Constructors
        /// <summary>
        ///     Initialize a new <see cref="Stack{T}"/> with default properties.
        /// </summary>
        public Stack()
        {
            last = null;
            first = null;
        }

        /// <summary>
        ///     Initialize a new <see cref="Stack{T}"/> with elements of <see cref="IEnumerable{T}"/> collection. 
        /// </summary>
        /// <param name="collection">
        ///     <see cref="IEnumerable{T}"/> collection to pushing to this stack
        /// </param>
        public Stack(IEnumerable<T> collection)
        {
            foreach (T item in collection)
                this.Push(item);
        }
        #endregion

        #region Properties
        /// <summary>
        ///     Get count of all elements to <see cref="Stack{T}"/>.
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
        ///     Add object to <see cref="Stack{T}"/>.
        /// </summary>
        /// <param name="data">
        ///     Object which be added to <see cref="Stack{T}"/>.
        /// </param>
        public void Push(T data)
        {
            Item<T> item = new Item<T>(data);
            if (first is null)
            {
                first = item;
                last = item;
            }
            else
            {
                item.Previous = first;
                first = item;
            }
        }

        /// <summary>
        ///     Remove and return item from the vertex of <see cref="Stack{T}"/>.
        /// </summary>
        /// <returns>
        ///     A object from vertex of <see cref="Stack{T}"/>.
        /// </returns>
        /// <exception cref="NotSupportedException"/>
        public T Pop()
        {
            T item;
            if (first is null)
                throw new NotSupportedException("Stack is empty!");
            else
            {
                item = first.Value;
                first = first.Previous;
            }
            return item;
        }

        /// <summary>
        ///     Return item from the vertex of <see cref="Stack{T}"/>.
        /// </summary>
        /// <returns>
        ///     A object from the vertex <see cref="Stack{T}"/>.
        /// </returns>
        /// <exception cref="NotSupportedException"/>
        public T Peek()
        {
            if (first is null)
                throw new NotSupportedException("Stack is empty!");
            else
                return first.Value;
        }

        /// <summary>
        ///     Clone <see cref="Stack{T}"/> to a new object.
        /// </summary>
        /// <returns>
        ///     A new object which equal <see cref="Stack{T}"/>.
        /// </returns>
        public object Clone()
        {
            Stack<T> stack = new Stack<T>()
            {
                last = this.last,
                first = this.first,
            };
            return stack;
        }

        /// <summary>
        ///     Remove all items of <see cref="Stack{T}"/>.
        /// </summary>
        public void Clear()
        {
            first = null;
            last = null;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Item<T> current = first;
            while (current != null)
            {
                yield return current.Value;
                current = current.Previous;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion

        /// <summary>
        ///     Implements <see cref="Stack"/> item.
        /// </summary>
        private class Item<T>
        {
            /// <summary>
            ///     Get current value of item.
            /// </summary>
            public T Value { get; }

            /// <summary>
            ///     Get or set previous <see cref="Item{T}"/> object.
            /// </summary>
            public Item<T> Previous { get; set; }

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