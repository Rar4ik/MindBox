using System.Linq.Expressions;
using Area.Implementation;
using Area.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Assert =  Xunit.Assert;

namespace UnitTestMindBox.ImplementationTests
{
    [TestClass]
    public class AreaCalculatorTest
    {
        [TestMethod]
        public void GetTriangleArea()
        {
            var triangleObj = new Triangle();
            triangleObj.MainSide = 1;
            triangleObj.SideB = 2;
            triangleObj.SideC = 2;

            var triangle = new AreaCalculator(triangleObj);
            var expected = 0.97;

            var result = triangle.GetTriangleArea();

            Assert.Equal(expected,result);
        }

        [TestMethod]
        public void GetCircleArea()
        {
            var circleObj = new Circle();
            circleObj.MainSide = 1;

            var circle = new AreaCalculator(circleObj);
            var expected = 3.14;

            var result = circle.GetCircleArea();

            Assert.Equal(expected,result);
        }
    }
}
