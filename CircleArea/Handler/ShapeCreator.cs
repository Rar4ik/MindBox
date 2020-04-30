using System;
using System.Collections.Generic;
using System.Linq;
using Area.Interfaces;
using Area.Model;

namespace Area.Handler
{
    public class ShapeCreator
    {
        public IShape GetShape(List<double> input)
        {
            if (input.Count == 1)
            {
                Circle circle = new Circle();
                circle.MainSide = input.FirstOrDefault();
                return circle;
            }
            else if (input.Count == 3)
            {
                Triangle triangle = new Triangle();
                triangle.MainSide = input[0];
                triangle.SideB = input[1];
                triangle.SideC = input[2];
                return triangle;
            }
            else
                throw new ArgumentException("Введено неверное количество символов" );

        }
    }
}
