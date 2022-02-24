using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Circle : Figure, IFigure
    {
        int diameter;

        public Circle(int diameter)
        {
            this.diameter = diameter;
        }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(diameter, 2);
        }
    }
}
