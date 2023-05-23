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
            if (side < 0 || high < 0)
            {
                return 0;
            }
            else
            {
                return (side * high) / 2;
            }
        }

        public static double SquareSquare(double side)
        {
            if (side < 0)
            {
                return 0;
            }
            else
            {
                return (side * side);
            }
            
        }

        public static double SquareRectangle(double side, double high)
        {
            if (side < 0 || high < 0)
            {
                return 0;
            }
            else
            {
                return (side * high);
            }
        }

        public static double SquareRhombus(double firstdiagonal, double seconddiagonal)
        {
            if (firstdiagonal < 0 || seconddiagonal < 0)
            {
                return 0;
            }
            else
            {
                return (firstdiagonal * seconddiagonal) / 2;
            }
            
        }

        public static double SquareCircle(double radius)
        {
            if (radius < 0)
            {
                return 0;
            }
            else
            {
                return radius * 2 * 3.14;
            }
            
        }
    }
}
