using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3_Poly
{
    internal class Rectangle : Geometri
    {
        // Property for Rectangle
        public double Length { get; set; }

        // Constructor for Rectangle class
        public Rectangle()
        {
            Length = 5; // Setting a default value for Length
        }

        // Overriding the Area method for Rectangle
        public override double Area()
        {
            return Length * Length; // Area of a square (length * length)
        }
    }
}
