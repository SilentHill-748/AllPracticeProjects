using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflaction
{
    [Geo(10, 15)]
    public class Photo : ITest
    {
        public Photo(string name)
        {
            Name = name;
            Path = Directory.GetCurrentDirectory() + "/";
        }



        public string Name { get; set; }

        public string Path { get; set; }
    }

    public interface ITest { }
}
