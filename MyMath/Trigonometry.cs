using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public class Trigonometry
    {
        public static double Sin(double cathetus, double hypotenuse)
        {
            if (cathetus < 0 || hypotenuse < 0)
            {
                return 0;
            }
            else
            {
                return cathetus / hypotenuse;
            }
            
        }
        public static double Cos(double cathetus, double hypotenuse)
        {
            if (cathetus < 0 || hypotenuse < 0)
            {
                return 0;
            }
            else
            {
                return cathetus / hypotenuse;
            }
        }
        public static double Tg(double firstcathetus, double secondcathetus)
        {
            if (firstcathetus < 0 || secondcathetus < 0)
            {
                return 0;
            }
            else
            {
                return firstcathetus / secondcathetus;
            }
        }
        public static double Ctg(double firstcathetus, double secondcathetus)
        {
            if (firstcathetus < 0 || secondcathetus < 0)
            {
                return 0;
            }
            else
            {
                return firstcathetus / secondcathetus;
            }
        }
    }
}
