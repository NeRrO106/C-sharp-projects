using System;

/*
In this project, you’ll use methods to build a program that calculates the material cost for any architect’s floor plan. For example, the floor plan of the Pantheon in Rome, Italy
*/

namespace ArchitectArithmetic
{
    class Program
    {
        static double Rect(double length, double width)
        {
            return length * width;
        }
        static double Circle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        static double Triangle(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }
        static void Teotihuacan()
        {
            double triangle = Triangle(750, 500);
            double rectangle = Rect(2500, 1500);
            double circle = Circle(375) / 2;
            double cost = (triangle + rectangle + circle) * 180;
            Console.WriteLine($"The cost is {cost} pesos");
        }
        static void Tajmahal()
        {
            double rect = Rect(90.5, 90.5);
            double triangle = Triangle(24, 24);
            double totalArea = rect - 4 * triangle;
            double cost = totalArea * 180;
            Console.WriteLine($"The cost is {cost} pesos");
        }
        static void Mosque()
        {
            double rect1 = Rect(180, 106);
            double rect2 = Rect(284, 264);
            double triangle = Triangle(84, 264);
            double totalArea = rect1 + (rect2 - triangle);
            double cost = totalArea * 180;
            Console.WriteLine($"The cost is {cost} pesos");
        }
        public static void Main(string[] args)
        {
            Teotihuacan();
            Tajmahal();
            Mosque();
        }
    }
}
