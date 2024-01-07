using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3_Poly
{
    internal class Square : Geometri
    {
        // Property for Square
        public double Side { get; set; }

        // Constructor for Square class
        public Square()
        {
            Side = 4; // Setting a default value for Side
        }

        // Overriding the Area method for Square
        public override double Area()
        {
            return Side * Side; // Area of a square (side * side)
        }
    }
}
