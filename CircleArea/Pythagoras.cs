using System;
using System.Collections.Generic;
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
        public void GetRightTriangle()
        {
            if (a > b && a > c)
                CheckRightTriangle(a, b, c);
            if (b > a && b > c)
                CheckRightTriangle(b, a, c);
            if (c > a && c > b)
                CheckRightTriangle(c, a, b);
            else
                Console.WriteLine("Треугольник не прямоугольный");
        }

        private void CheckRightTriangle(double biggerSide, double smallSide, double smallSide1)
        {
            Console.WriteLine(
                Math.Round(Math.Pow(biggerSide, 2), 2) ==
                Math.Round(Math.Pow(smallSide, 2), 2) + Math.Round(Math.Pow(smallSide1, 2), 2)
                    ? "Треугольник прямоугольный"
                    : "Треугольник не прямоугольный");
        }
    }
}
