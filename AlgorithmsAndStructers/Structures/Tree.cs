using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public class Tree<T>
        where T : IComparable<T>, IComparable
    {
        private TreeNode<T> _root;
        private int _count;


        public Tree(IEnumerable<T> items)
        {
            foreach (T item in items)
                AddNode(item);
        }


        public TreeNode<T> Root
        {
            get { return _root; }
        }

        public int Count
        {
            get { return _count; }
        }


        public void AddNode(T data)
        {
            if (_root == null)
            {
                _root = new TreeNode<T>(data);
                _count = 1;
                return;
            }

            _root.Add(data);
            _count++;
        }


        public List<T> Inorder()
        {
            if (Root == null)
                return new List<T>();

            return Inorder(Root);
        }

        private List<T> Inorder(TreeNode<T> node)
        {
            List<T> list = new List<T>();

            if (node != null)
            {
                if (node.Left != null)
                    list.AddRange(Inorder(node.Left));

                list.Add(node.Data);

                if (node.Right != null)
                    list.AddRange(Inorder(node.Right));
            }

            return list;
        }
    }
}
