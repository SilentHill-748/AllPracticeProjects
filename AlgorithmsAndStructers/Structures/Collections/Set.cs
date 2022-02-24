using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures.Collections
{
    public class Set<T>
    {
        private List<T> _items;


        public Set()
        {
            _items = new List<T>();
        }

        public Set(T data)
        {
            _items = new List<T>() { data };
        }

        public Set(IEnumerable<T> collection) : this()
        {
            foreach (T item in collection)
                _items.Add(item);
        }


        public void Add(T data)
        {
            if (!_items.Contains(data))
                _items.Add(data);
        }

        public void Remove(T data)
        {
            if (_items.Contains(data))
                _items.Remove(data);
        }

        public Set<T> Union(Set<T> set)
        {
            Set<T> result = this;

            for (int i = 0; i < set._items.Count; i++)
            {
                if (!result._items.Contains(set._items[i]))
                    result._items.Add(set._items[i]);
            }

            return result;
        }

        public Set<T> Intersect(Set<T> set)
        {
            Set<T> high = set;
            Set<T> low = this;

            if (_items.Count > set._items.Count)
            {
                high = this;
                low = set;
            }

            Set<T> result = new Set<T>();

            for (int i = 0; i < low._items.Count; i++)
            {
                if (high._items.Contains(low._items[i]))
                    result.Add(low._items[i]);
            }

            return result;
        }

        public Set<T> Difference(Set<T> set)
        {
            Set<T> result = this;
            Set<T> intersect = Intersect(set);

            for (int i = 0; i < intersect._items.Count; i++)
            {
                result._items.Remove(intersect._items[i]);
            }

            return result;
        }

        public bool IsSubset(Set<T> set)
        {
            for (int i = 0; i < set._items.Count; i++)
            {
                if (!_items.Contains(set._items[i]))
                    return false;
            }

            return true;
        }

        public Set<T> SymmetricDifference(Set<T> set)
        {
            Set<T> setB = new Set<T>(set._items);
            Set<T> result = new Set<T>();

            for (int i = 0; i < _items.Count; i++)
            {
                if (!setB._items.Contains(_items[i]))
                    result.Add(_items[i]);
                else
                    setB._items.Remove(_items[i]);
            }

            return result.Union(setB);
        }

        public override bool Equals(object obj)
        {
            Set<T> set = obj as Set<T>;

            if (set != null)
            {
                for (int i = 0; i < set._items.Count; i++)
                    if (!_items[i].Equals(set._items[i]))
                        return false;
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return _items.GetHashCode();
        }
    }
}
