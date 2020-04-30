using System.Collections.Generic;
using Area.Handler;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Xunit.Assert;

namespace UnitTestMindBox.HandlerTests
{
    [TestClass]
    public class InputHandlerTest
    {
        [TestMethod]
        public void Transform_string_to_ListDouble()
        {
            string testString = "1,2.1,3";
            var handler = new InputHandler();

            var result = handler.TransformInput(testString);

            Assert.IsType<List<double>>(result);
        }
    }
}
