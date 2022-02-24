using System;
using System.Collections;
using System.Collections.Generic;

namespace Structures.Collections
{
    /// <summary>
    ///     Implements interface <see cref="IList{T}"/> using an <see cref="Array"/> with dynamic resizing.
    /// </summary>
    public class ArrayList<T> : IEnumerable<T>, IList<T>, ICollection<T>, ICloneable
    {
        #region Private fields
        private T[] _collection;
        #endregion

        /// <summary>
        ///     Initialize new object <see cref="ArrayList{T}"/> with default properties.
        /// </summary>
        public ArrayList()
        {
            _collection = new T[0];
        }

        #region Properties
        /// <summary>
        ///     Get or set value at the specified index.
        /// </summary>
        /// <param name="index">Index at which get or set value.</param>
        /// <returns>
        ///     Value from <see cref="ArrayList{T}"/> at the specified index.
        /// </returns>
        public T this[int index]
        {
            get => _collection[index];
            set
            {
                if (IsReadOnly)
                    throw new NotSupportedException("Collection is read-only!");

                if (value == null)
                    throw new ArgumentNullException();
                _collection[index] = value;
            }
        }

        /// <summary>
        ///     Count of elements in <see cref="ArrayList{T}"/>.
        /// </summary>
        public int Count => _collection.Length;

        /// <summary>
        ///     Gets a value indicating whether the collection <see cref="ICollection{T}"/> is read-only.
        /// </summary>
        public bool IsReadOnly { get; set; } = false;
        #endregion

        #region Public methods
        /// <summary>
        ///     Add new element to <see cref="IList{T}"/>.
        /// </summary>
        /// <param name="item">Object which need add to <see cref="IList{T}"/>.</param>
        /// <exception cref="NotSupportedException"/>
        public void Add(T item)
        {
            if (IsReadOnly)
                throw new NotSupportedException("Collection is read-only!");
            _collection = AddItem(item);
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
                throw new NotSupportedException("Collection is read-only!");

            if (Contains(item))
            {
                _collection = RemoveItem(item);
                return true;
            }
            else
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
                throw new NotSupportedException("Collection is read-only!");
            if (index < 0 || index >= Count)
                throw new ArgumentOutOfRangeException("index", "Index was out of range!");
            else
                _collection = RemoveItemAt(index);
        }

        /// <summary>
        ///     Insert new element to <see cref="IList{T}"/> at the specified index.
        /// </summary>
        /// <param name="index">Index, after which need insert element.</param>
        /// <param name="item">Object which needed insert to <see cref="IList{T}"/>.</param>
        /// <exception cref="NotSupportedException"/>
        public void Insert(int index, T item)
        {
            if (IsReadOnly)
                throw new NotSupportedException("Collection is read-only!");

            T[] array = new T[Count + 1];
            for (int i = 0, j = 0; i < array.Length; i++, j++)
            {
                if (i == index + 1)
                {
                    array[i] = item;
                    j--;
                }
                else
                    array[i] = _collection[j];
            }
            _collection = array;
        }

        /// <summary>
        ///     Delete all elements from collection <see cref="ICollection{T}"/>
        /// </summary>
        /// <exception cref="NotSupportedException"/>
        public void Clear()
        {
            if (IsReadOnly)
                throw new NotSupportedException("Collection is read-only!");
            _collection = new T[0];
        }

        /// <summary>
        ///     Create new object which is equivalent cloned <see cref="List{T}"/>.
        /// </summary>
        /// <returns>
        ///     A new object that is equivalent to this <see cref="List{T}"/>.
        /// </returns>
        public object Clone()
        {
            var list = new ArrayList<T>
            {
                _collection = (T[])this._collection.Clone(),
                IsReadOnly = IsReadOnly
            };
            return list;
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
            for (int i = 0; i < Count; i++)
            {
                if (this[i].Equals(item))
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
                throw new ArgumentException("Array index is more than array length!");
            for (int i = arrayIndex, j = 0; j < Count; i++, j++)
                array[i] = this[j];
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
            for (int i = 0; i < Count; i++)
                if (this[i].Equals(item)) return i;
            
            return -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in _collection)
                yield return item;
        }
        #endregion

        #region Private methods
        private T[] RemoveItem(T item)
        {
            int index = IndexOf(item);
            return RemoveItemAt(index);
        }

        private T[] RemoveItemAt(int index)
        {
            T[] temp = new T[Count - 1];
            for (int i = 0, j = 0; i < Count; i++, j++)
            {
                if (i == index)
                {
                    j--;
                    continue;
                }
                temp[j] = _collection[i];
            }
            return temp;
        }

        private T[] AddItem(T item)
        {
            T[] temp = new T[Count + 1];
            Array.Copy(_collection, temp, Count);
            temp[Count] = item;
            return (T[])temp.Clone();
        }
        #endregion
    }
}