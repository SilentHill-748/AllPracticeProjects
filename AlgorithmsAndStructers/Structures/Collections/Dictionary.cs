using System;
using System.Linq;
using Structures.Collections.Model;
using System.Collections;

namespace Structures.Collections
{
    public class Dictionary<TKey, TValue> 
    {
        // TODO: Класс Dictionary не описан! Коллекции записаны не все!
        private readonly List<KeyValuePair<TKey, TValue>> _records;

        public Dictionary()
        {
            this._records = new List<KeyValuePair<TKey, TValue>>();
            Values = new ValuesCollecion<TValue>();
            Keys = new KeysCollection<TKey>();
        }

        public KeysCollection<TKey> Keys { get; }
        public ValuesCollecion<TValue> Values { get; }

        public TValue this[TKey key]
        {
            get
            {
                if (!Keys.Contains(key))
                {
                    throw new ArgumentException("Record with this key is not found!");
                }

                return _records.First(pair => pair.Key.Equals(key)).Value;
            }
        }

        #region Public methods
        public void Add(TKey key, TValue value)
        {
            var pair = new KeyValuePair<TKey, TValue>(key, value);
            _records.Add(pair);
            Keys.Add(key);
            Values.Add(value);
        }
        #endregion

        #region Private methods

        #endregion

        #region Public objects
        public class KeysCollection<TKey>
        {
            private ArrayList<TKey> _keys;

            public KeysCollection()
            {
                _keys = new ArrayList<TKey>();
            }

            public void Add(TKey key)
            {
                _keys.Add(key);
            }

            public void Remove(TKey key)
            {
                _keys.Remove(key);
            }

            public bool Contains(TKey key)
            {
                return _keys.Contains(key);
            }
        }

        public class ValuesCollecion<TValue>
        {
            private ArrayList<TValue> _values;

            public ValuesCollecion()
            {
                _values = new ArrayList<TValue>();
            }

            public void Add(TValue value)
            {
                _values.Add(value);
            }

            public void Remove(TValue value)
            {
                _values.Remove(value);
            }
        }
        #endregion
    }
}
