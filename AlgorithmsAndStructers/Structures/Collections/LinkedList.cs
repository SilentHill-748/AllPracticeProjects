using System;
using System.Collections;
using System.Collections.Generic;

using Structures.Collections.Model;

namespace Structures.Collections
{
    /// <summary>
    ///     Represent <see cref="LinkedList{T}"/> collection with access to elements at index.
    /// </summary>
    public class LinkedList<T> : IEnumerable<T>, ICloneable
    {
        #region Private fields
        private int _count;
        #endregion

        /// <summary>
        ///     Initialize a new instance <see cref="LinkedList{T}"/> with default properties.
        /// </summary>
        public LinkedList()
        {
            this._count = 0;
        }

        #region Properties
        /// <summary>
        ///     First node at collection.
        /// </summary>
        public Node<T> First { get; private set; }

        /// <summary>
        ///     Last node at collection.
        /// </summary>
        public Node<T> Last { get; private set; }

        /// <summary>
        ///     Count of elements at this collection.
        /// </summary>
        public int Count
        {
            get
            {
                _count = 0;
                foreach (var _ in this)
                    _count++;
                return _count;
            }
        }

        /// <summary>
        ///     Find value of node at index.
        /// </summary>
        /// <returns>
        ///     Value of node at index.
        /// </returns>
        /// <exception cref="IndexOutOfRangeException"/>
        public T this[int index]
        {
            get => Find(index).Value;
            set
            {
                if (value != null)
                    Find(index).Value = value;
            }
        }
        #endregion

        #region Public methods
        /// <summary>
        ///    Insert value after selected item.
        /// </summary>
        /// <exception cref="ArgumentException"/>
        public void AddAfter(T item, T value)
        {
            var data = new Node<T>(value);
            if (Contains(item))
            {
                var findedItem = Find(IndexOf(item));

                if (findedItem.Next == null)
                {
                    findedItem.Next = data;
                    Last = data;
                    data.Previous = findedItem;
                }
                else
                {
                    var next = findedItem.Next;
                    findedItem.Next = data;
                    data.Next = next;
                    next.Previous = data;
                    data.Previous = findedItem;
                }
            }
            else
                throw new ArgumentException("Item doesn't exists!");
        }

        /// <summary>
        ///     Insert value before selected item.
        /// </summary>
        /// <exception cref="ArgumentException"/>
        public void AddBefore(T item, T value)
        {
            var data = new Node<T>(value);
            if (Contains(item))
            {
                var findedItem = Find(IndexOf(item));

                if (findedItem.Previous == null)
                {
                    findedItem.Previous = data;
                    First = data;
                    data.Next = findedItem;
                }
                else
                {
                    var previous = findedItem.Previous;
                    findedItem.Previous = data;
                    data.Previous = previous;
                    previous.Next = data;
                    data.Next = findedItem;
                }
            }
            else
                throw new ArgumentException("Item doesn't exists!");
        }

        /// <summary>
        ///     Add value to start collection.
        /// </summary>
        public void AddFirst(T value)
        {
            var node = new Node<T>(value);

            if (First != null)
            {
                First.Previous = node;
                node.Next = First;
                First = node;
            }
            else
                SetFirstItem(value);
        }

        /// <summary>
        ///     Add value to end collection.
        /// </summary>
        public void AddLast(T value)
        {
            var node = new Node<T>(value);

            if (Last != null)
            {
                Last.Next = node;
                node.Previous = Last;
                Last = node;
            }
            else
                SetFirstItem(value);
        }

        /// <summary>
        ///     Remove item from collection.
        /// </summary>
        /// <returns>
        ///     True - item removed successfully -or- False - item not found.
        /// </returns>
        public bool Remove(T item)
        {
            if (Contains(item))
            {
                var findedItem = Find(IndexOf(item));
                if (findedItem.Previous != null)
                {
                    if (findedItem.Next != null)
                    {
                        findedItem.Previous.Next = findedItem.Next;
                        findedItem.Next.Previous = findedItem.Previous;
                    }
                    else
                        RemoveLast();
                }
                else
                    RemoveFirst();
                return true;
            }
            else
                return false;
        }

        /// <summary>
        ///     Remove first node.
        /// </summary>
        public void RemoveFirst()
        {
            var first = First;

            if (first != null)
            {
                First = first.Next;
                First.Previous = null;
            }
            else
                throw new NotSupportedException("Collection is empty!");
        }

        /// <summary>
        ///     Remove last node.
        /// </summary>
        public void RemoveLast()
        {
            var last = Last;

            if (last != null)
            {
                Last = last.Previous;
                Last.Next = null;
            }
            else
                throw new NotSupportedException("Collection is empty!");
        }

        /// <summary>
        ///     Check item at this collection.
        /// </summary>
        /// <param name="item">Checking value</param>
        /// <returns>
        ///     True - если такой элемент присудствует и false, если его нет.
        /// </returns>
        public bool Contains(T item)
        {
            if (IndexOf(item) == -1)
                return false;
            return true;
        }

        public int IndexOf(T item)
        {
            int counter = 0;
            var current = First;
            while (counter < Count)
            {
                if (current.Value.Equals(item))
                    return counter;
                current = current.Next;
                counter++;
            }
            return -1;
        }

        /// <summary>
        ///     Fill array LinkedList items at selected start array index.
        /// </summary>
        /// <exception cref="ArgumentNullException"/>
        /// <exception cref="IndexOutOfRangeException"/>
        /// <exception cref="ArgumentException"/>
        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array is null)
                throw new ArgumentNullException("array", "Array is null!");
            if (arrayIndex >= array.Length || arrayIndex < 0)
                throw new IndexOutOfRangeException("\"arrayIndex\" is not in range of array!");
            if (array.Length < Count)
                throw new ArgumentException("Collection is more than array!");

            for (int i = 0; i < Count; i++, arrayIndex++)
                array[arrayIndex] = this[i];
        }

        /// <summary>
        ///  Clear all collection.
        /// </summary>
        public void Clear()
        {
            First = null;
            Last = null;
        }

        /// <summary>
        ///     Clone <see cref="LinkedList{T}"/> to new object.
        /// </summary>
        /// <returns> 
        ///     Object, equivalent this <see cref="LinkedList{T}"/>.
        /// </returns>
        public object Clone()
        {
            return new LinkedList<T>()
            {
                First = this.First,
                Last = this.Last,
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = First;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
        #endregion

        #region Private methods
        /// <summary>
        ///     Find node at index.
        /// </summary>
        /// <returns>
        ///     Finded node.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException"/>
        private Node<T> Find(int index)
        {
            if (index < 0 || index >= Count)
                throw new IndexOutOfRangeException("Index was not in range of collection!");
            else
            {
                if (index > Count / 2)
                    return AtIndexLast(index);
                else
                    return AtIndexFirst(index);
            }
        }

        /// <summary>
        ///     Bypass collection at left to right.
        /// </summary>
        /// <returns>
        ///     Finded node at index.
        /// </returns>
        private Node<T> AtIndexFirst(int index)
        {
            var current = First;
            for (int i = 0; i < index; i++)
                current = current.Next;
            return current;
        }

        /// <summary>
        ///     Bypass collection at right to left.
        /// </summary>
        /// <returns>
        ///     Finded node at index
        /// </returns>
        private Node<T> AtIndexLast(int index)
        {
            var current = Last;
            for (int i = Count - 1; i > index; i--)
                current = current.Previous;
            return current;
        }

        /// <summary>
        ///     Initialization <see cref="LinkedList{T}"/> with first item.
        /// </summary>
        /// <param name="data">
        ///     Data which be first at this object.
        /// </param>
        private void SetFirstItem(T data)
        {
            var node = new Node<T>(data);
            First = node;
            Last = node;
        }
        #endregion
    }
}