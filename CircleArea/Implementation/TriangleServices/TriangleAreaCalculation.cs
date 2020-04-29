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
            return result;
        }
    }
}
