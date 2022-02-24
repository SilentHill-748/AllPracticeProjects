using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Structures;

namespace Algorithms.Sorts
{
    public class TreeSort<T>
        where T : IComparable, IComparable<T>
    {
        public List<T> Sort(IEnumerable<T> items)
        {
            Tree<T> tree = new Tree<T>(items);
            var sorted = tree.Inorder();

            return sorted;
        }
    }
}
