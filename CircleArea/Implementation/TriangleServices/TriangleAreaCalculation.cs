using System;
using Area.Model;

namespace Area.Implementation.TriangleServices
{
    public class TriangleAreaCalculation
    {
        public double GetArea(double per, Triangle t)
        {
            double sides = per * (per - t.MainSide) * (per - t.SideB) * (per - t.SideC);
            double result = Math.Sqrt(sides);
            if (result == 0)
            {
                Console.WriteLine("Cумма длин каждых двух сторон должна быть больше длины третьей стороны");
                return 0;
            }
            else
                return Math.Round(result,2);
        }
    }
}
