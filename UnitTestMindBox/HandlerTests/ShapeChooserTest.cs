using Area.Handler;
using Area.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Assert = Xunit.Assert;

namespace UnitTestMindBox.HandlerTests
{
    [TestClass]
    public class ShapeChooserTest
    {
        [TestMethod]
        public void Get_triangle_shape_area()
        {
            var moqTriangleShape = new Mock<Triangle>();
            var shape = new ShapeChooser();

            var resultTriangle = shape.GetShape(moqTriangleShape.Object);

            Assert.IsType<double>(resultTriangle);
        }

        [TestMethod]
        public void Get_circle_shape_area()
        {
            var moqCircleShape = new Mock<Circle>();
            var shape = new ShapeChooser();

            var resultCircle = shape.GetShape(moqCircleShape.Object);

            Assert.IsType<double>(resultCircle);
        }
    }
}
