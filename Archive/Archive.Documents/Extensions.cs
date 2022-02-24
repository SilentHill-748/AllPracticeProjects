using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive.Documents
{
    //TODO: Определи место этому файлу.
    public static class Extensions
    {
        public static bool Contains(this string str, params string[] substrings)
        {
            for (int i = 0; i < substrings.Length; i++)
            {
                if (str.Contains(substrings[i]))
                    return true;
            }
            return false;
        }
    }
}
