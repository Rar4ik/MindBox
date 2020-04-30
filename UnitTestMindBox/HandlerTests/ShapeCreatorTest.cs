using System;
using System.Collections.Generic;
using Area.Handler;
using Area.Interfaces;
using Area.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Xunit.Assert;

namespace UnitTestMindBox.HandlerTests
{
    [TestClass]
    public class ShapeCreatorTest
    {
        ShapeCreator shape = new ShapeCreator();
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Get_Shape_type_execption()
        {
            var doubleList = new List<double>(){1,2};

            var result = shape.GetShape(doubleList);

            Assert.IsType<IShape>(result);
        }

        [TestMethod]
        public void Get_circle_shape()
        {
            var doubleList = new List<double>(){1.2};

            var result = shape.GetShape(doubleList);

            Assert.IsType<Circle>(result);
        }
        [TestMethod]
        public void GEt_triangle_shape()
        {
            var doubleList = new List<double>() { 1.2,2,1 };

            var result = shape.GetShape(doubleList);

            Assert.IsType<Triangle>(result);
        }
    }
}
