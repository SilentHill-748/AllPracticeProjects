using System;
using System.Collections;
using System.Collections.Generic;

using Structures.Collections.Model;

namespace Structures.Collections
{
    /// <summary>
    ///     Implements strongly-typed <see cref="List{T}"/> of objects acessed at index. 
    /// </summary>
    public class List<T> : IEnumerable<T>, ICloneable, IList<T>, ICollection<T>
    {
        #region Private fields
        private int _count;

        private Item<T> head;
        private Item<T> tail;
        #endregion

        #region Constructors
        /// <summary>
        ///     Initialize a new instance <see cref="List{T}"/> with default properties.
        /// </summary>
        public List()
        {
            head = null;
            tail = null;
        }

        /// <summary>
        ///     Initialize a new instance <see cref="List{T}"/> with one element.
        /// </summary>
        public List(T data)
        {
            InitFirst(data);
        }
        #endregion

        #region Properties and indexators
        /// <summary>
        ///     Get count of elements at <see cref="List{T}"/>.
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
        ///     Gets a value indicating whether the collection <see cref="ICollection{T}"/> is read-only.
        /// </summary>
        public bool IsReadOnly { get; set; } = false;

        /// <summary> Get or set value at index.</summary>
        /// <param name="index"> Index of element at <see cref="List{T}"/>.</param>
        /// <returns> Value at index.</returns>
        /// <exception cref="NotSupportedException"/>
        /// <exception cref="IndexOutOfRangeException"/>
        public T this[int index]
        {
            get => AtIndex(index).Value;
            set
            {
                if (IsReadOnly)
                    throw new NotSupportedException("This list is read-only!");
                if (index < 0 || index >= Count)
                    throw new IndexOutOfRangeException("Index is more than count of elements at list!");
                var item = AtIndex(index);
                item.Value = value;
            }
        }
        #endregion

        #region Public methods
        /// <summary>
        ///     Add new element to <see cref="IList{T}"/>.
        /// </summary>
        /// <param name="data">Object which need add to <see cref="IList{T}"/>.</param>
        /// <exception cref="NotSupportedException"/>
        public void Add(T data)
        {
            if (IsReadOnly)
                throw new NotSupportedException("This list is read-only!");
            if (head is null)
                InitFirst(data);
            else
            {
                var item = new Item<T>(data);
                tail.Next = item;
                tail = item;
            }
        }

        /// <summary>
        ///     Remove element from <see cref="IList{T}"/>.
        /// </summary>
        /// <param name="item">Object which need remove from <see cref="IList{T}"/>.</param>
        /// <returns>
        ///     True, if object was removed successfully. False, if object not exists.
        /// </returns>
        /// <exception cref="NotSupportedException"/>
        public bool Remove(T item)
        {
            if (IsReadOnly)
                throw new NotSupportedException("This list is read-only!");

            Item<T> current = head;     // Начальный элемент коллекции.

            while (current.Next != null)
            {
                if (current.Value.Equals(item))
                {
                    head = current.Next;
                    return true;
                }

                if (current.Next.Value.Equals(item))
                {
                    Item<T> temp = current.Next.Next;
                    current.Next = null;
                    current.Next = temp;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        /// <summary>
        ///     Remove elemenet <see cref="IList{T}"/> located at the specified index.
        /// </summary>
        /// <param name="index">Index of element.</param>
        /// <exception cref="NotSupportedException"/>
        /// <exception cref="ArgumentOutOfRangeException"/>
        public void RemoveAt(int index)
        {
            if (IsReadOnly)
                throw new NotSupportedException("This list is read-only!");
            bool isRemoved = Remove(AtIndex(index).Value);
            if (!isRemoved)
                throw new ArgumentOutOfRangeException();
        }

        /// <summary>
        ///     Ascending sort using shell sort algorithm. 
        /// </summary>
        public void Sort()
        {
            if (IsReadOnly)
                throw new NotSupportedException("This list is read-only!");

            int step = Count / 2;
            while (step > 0)
            {
                for (int i = step; i < Count; i++)
                {
                    int j = i;
                    while (j >= step)
                    {
                        Item<T> left = AtIndex(j - step);
                        Item<T> right = AtIndex(j);

                        if (left.CompareTo(right.Value) == 1)
                            Swap(left, right);
                        j -= step;
                    }
                }
                step /= 2;
            }
        }

        /// <summary>
        ///     Delete all elements from collection <see cref="ICollection{T}"/>
        /// </summary>
        /// <exception cref="NotSupportedException"/>
        public void Clear()
        {
            if (IsReadOnly)
                throw new NotSupportedException("This collection is read-only!");
            head = null;
            tail = null;
        }

        /// <summary>
        ///     Determines if contains element in collection <see cref="ICollection{T}"/>.
        /// </summary>
        /// <param name="item">Object which need find in collection <see cref="ICollection{T}"/>.</param>
        /// <returns>
        ///     True, if <see cref="ICollection{T}"/> is contains specified element.
        ///     False, if specified element not exists at collection <see cref="ICollection{T}"/>.
        /// </returns>
        public bool Contains(T item)
        {
            foreach (var value in this)
            {
                if (value.Equals(item))
                    return true;
            }
            return false;
        }

        /// <summary>
        ///     Copy all elements from <see cref="ICollection{T}"/>
        ///     to <see cref="Array"/> begin with the specified index of <see cref="Array"/>
        /// </summary>
        /// <param name="array"><see cref="Array"/> 
        ///     at which needed copy elements of collection <see cref="ICollection{T}"/>.
        /// </param>
        /// <param name="arrayIndex">
        ///     Index of <see cref="Array"/> with which begin copy of elements 
        ///     of collection <see cref="ICollection{T}"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"/>
        /// <exception cref="ArgumentException"/>
        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array is null)
                throw new ArgumentNullException();
            if (arrayIndex > array.Length)
                throw new ArgumentException("Array index is more than array length");
            foreach (var value in this)
            {
                array[arrayIndex] = value;
                arrayIndex++;
            }
        }

        /// <summary>
        ///     Return index of the specified element.
        /// </summary>
        /// <param name="item">Object which index need return.</param>
        /// <returns>
        ///     Index of element or -1 if element not found.
        /// </returns>
        public int IndexOf(T item)
        {
            int counter = 0;
            var current = (Item<T>)head.Clone();
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
        ///     Insert new element to <see cref="IList{T}"/> at the specified index.
        /// </summary>
        /// <param name="index">Index, after which need insert element.</param>
        /// <param name="item">Object which needed insert to <see cref="IList{T}"/>.</param>
        /// <exception cref="NotSupportedException"/>
        /// <exception cref="ArgumentOutOfRangeException"/>
        public void Insert(int index, T item)
        {
            if (IsReadOnly)
                throw new NotSupportedException("This collection is read-only!");
            if (index < 0 || index >= Count)
                throw new ArgumentOutOfRangeException();
            Item<T> insertItem = new Item<T>(item);
            Item<T> itemAtIndex = AtIndex(index);

            insertItem.Next =itemAtIndex.Next;
            itemAtIndex.Next = insertItem;
        }

        /// <summary>
        ///     Create new object which is equivalent cloned <see cref="List{T}"/>.
        /// </summary>
        /// <returns>
        ///     A new object that is equivalent to this <see cref="List{T}"/>.
        /// </returns>
        public object Clone()
        {
            return new List<T>()
            {
                head = this.head,
                tail = this.tail,
                IsReadOnly = IsReadOnly
            };
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        #endregion

        #region Private methods
        private Item<T> AtIndex(int index)
        {
            if (index < 0 || index >= Count)
                throw new ArgumentOutOfRangeException();

            var item = head;
            for (int i = 0; i < index; i++)
                item = item.Next;
            return item;
        }

        private void InitFirst(T data)
        {
            var item = new Item<T>(data);

            head = item;
            tail = item;
        }

        private void Swap(Item<T> left, Item<T> right)
        {
            T temp = left.Value;
            left.Value = right.Value;
            right.Value = temp;
        }
        #endregion
    }
}