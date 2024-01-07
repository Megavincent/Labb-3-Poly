using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3_Poly
{
    internal class Circle : Geometri
    {
        // Property for Circle
        public double Radius { get; set; }

        // Constructor for Circle class
        public Circle()
        {
            Radius = 3; // Setting a default value for Radius
        }

        // Overriding the Area method for Circle
        public override double Area()
        {
            return Math.PI * Radius * Radius; // Area of a circle (π * r^2)
        }
    }
}
