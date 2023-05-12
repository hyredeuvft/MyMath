using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public class Geometry
    {
        public static double SquareTriangle(double side, double high)
        {
            return (side * high) / 2;
        }

        public static double SquareSquare(double side)
        {
            return (side * side);
        }

        public static double SquareRectangle(double side, double high)
        {
            return (side * high);
        }

        public static double SquareRhombus(double firstdiagonal, double seconddiagonal)
        {
            return (firstdiagonal * seconddiagonal) / 2;
        }

        public static double SquareCircle(double radius)
        {
            return radius * 2 * 3.14;
        }
    }
}
