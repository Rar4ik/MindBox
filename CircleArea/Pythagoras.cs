using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Area.Model;

namespace Area
{
    public class Pythagoras
    {
        private double a;
        private double b;
        private double c;
        public Pythagoras(Triangle triangle)
        {
            a = triangle.MainSide;
            b = triangle.SideB;
            c = triangle.SideC;
        }
        public bool GetRightTriangle()
        {
            bool flag = false;
            if (a > b && a > c)
            {
                flag = CheckRightTriangle(a, b, c, flag);
                return flag;
            }

            if (b > a && b > c)
            {
                flag = CheckRightTriangle(b, a, c, flag);
                return flag;
            }

            if (c > a && c > b)
            {
                flag =  CheckRightTriangle(c, a, b, flag);
                return flag;
            }
            else
                return flag;
        }

        private bool CheckRightTriangle(double biggerSide, double smallSide, double smallSide1, bool flag)
        {
            if (Math.Round(Math.Pow(biggerSide, 2), 2) ==
                Math.Round(Math.Pow(smallSide, 2), 2) + Math.Round(Math.Pow(smallSide1, 2), 2))
            {
                return flag = true;
            }
            else
               return flag;
        }
    }
}
