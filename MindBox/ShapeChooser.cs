using System;
using System.Collections.Generic;
using System.Text;
using Area.Implementation;
using Area.Interfaces;
using Area.Model;

namespace MindBox
{
    public class ShapeChooser
    {
        public double GetShape(IShape shape)
        {
            if (shape is Circle)
            {
                AreaCalculator areaCalculator = new AreaCalculator((Circle)shape);
                var areaOfCircle = areaCalculator.GetCircleArea();
                return areaOfCircle;
            }
            else
            {
                AreaCalculator areaCalculator = new AreaCalculator((Triangle)shape);
                var areaOfTriangle = areaCalculator.GetTriangleArea();
                return areaOfTriangle;
            }
        }
    }
}
