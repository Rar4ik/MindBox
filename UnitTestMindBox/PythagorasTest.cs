using System;
using System.Collections.Generic;
using System.Text;
using Area;
using Area.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert =Xunit.Assert;

namespace UnitTestMindBox
{
    [TestClass]
    public class PythagorasTest
    {
        [TestMethod]
        public void Get_right_angle()
        {
            Triangle triangleObj = new Triangle();
            triangleObj.MainSide = 1;
            triangleObj.SideB = 0.71;
            triangleObj.SideC = 0.71;
            var triangle = new Pythagoras(triangleObj);

            bool expected = true;
            var result = triangle.GetRightTriangle();

            Assert.Equal(expected,result);
        }
    }
}
