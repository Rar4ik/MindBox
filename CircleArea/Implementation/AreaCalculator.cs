using System;
using System.Collections.Generic;
using System.Text;
using Area.Implementation.CircleServices;
using Area.Implementation.TriangleServices;
using Area.Model;

namespace Area.Implementation
{
    public class AreaCalculator
    {
        private readonly Circle _circle;
        private readonly Triangle _triangle;
        public AreaCalculator(Triangle t)
        {
            _triangle = t;
        }

        public AreaCalculator(Circle c)
        {
            _circle = c;
        }

        public double GetTriangleArea()
        {
            Pythagoras p = new Pythagoras(_triangle);
            var result = p.GetRightTriangle();
            Console.WriteLine(result ? "Треугольник прямоугольный" : "Треугольник не прямоугольный");

            SemiPerimeterCalculation semiPerimeter = new SemiPerimeterCalculation();
            var semiPerimeterResult = semiPerimeter.GetSemiPerimeter(_triangle);

            TriangleAreaCalculation triangleArea = new TriangleAreaCalculation();
            var triangleAreaResult = triangleArea.GetArea(semiPerimeterResult, _triangle);

            return triangleAreaResult;
        }

        public double GetCircleArea()
        {
            CircleAreaCalculation circleArea = new CircleAreaCalculation();
            var result = circleArea.GetCircleArea(_circle);

            return result;
        }
    }
}
