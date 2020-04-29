using Area.Model;

namespace Area.Implementation.TriangleServices
{
    public class SemiPerimeterCalculation
    {
        private const int two = 2;
        public double GetSemiPerimeter(Triangle t)
        {
            var sPerimeter = (t.MainSide + t.SideB + t.SideC) / two;
            return sPerimeter;
        }
    }
}
