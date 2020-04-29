using System;
using System.Collections.Generic;
using System.Text;
using Area.Model;

namespace Area.Implementation.CircleServices
{
    public class CircleAreaCalculation
    {
        private const double _p = 3.14;
        public double GetCircleArea(Circle c)
        {
            double square = c.MainSide * c.MainSide;
            double circleResult = _p * square;
            return circleResult;
        }
    }
}
