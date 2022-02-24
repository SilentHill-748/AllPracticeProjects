using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public class TreeNode<T> : IComparable<T>
        where T : IComparable<T>
    {
        private readonly T _data;
        private TreeNode<T> _left;
        private TreeNode<T> _right;


        public TreeNode(T data)
        {
            _data = data;
        }


        public TreeNode<T> Left
        {
            get { return _left; }
        }

        public TreeNode<T> Right
        {
            get { return _right; }
        }

        public T Data
        {
            get { return _data; }
        }


        public void Add(T data)
        {
            TreeNode<T> node = new TreeNode<T>(data);

            if (node.Data.CompareTo(Data) == -1)
            {// left node
                if (_left is null)
                    _left = node;
                else
                    _left.Add(data);
            }
            else
            {// right node
                if (Right is null)
                    _right = node;
                else
                    _right.Add(data);
            }
        }

        public int CompareTo(T other)
        {
            if (other is TreeNode<T> item)
                return item.CompareTo(_data);
            else
                throw new ArgumentException("Не совпадение типов");
        }

        public override string ToString()
        {
            return _data.ToString();
        }
    }
}
