using System.Drawing;

namespace Labb_3_Poly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating object references from the Geometri class pointing to objects of each child class
            Geometri rectangle = new Rectangle();
            Geometri square = new Square();
            Geometri circle = new Circle();

            // Calculating and printing the area of each object using the overridden Area method
            Console.WriteLine("Area of Rectangle: " + rectangle.Area());
            Console.WriteLine("Area of Square: " + square.Area());
            Console.WriteLine("Area of Circle: " + circle.Area());
        }
    }
}
