using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaAndPerimeter;

namespace AreaAndPerimeterUnitTest
{
    [TestClass]
    public class RectangleUnitTest
    {
        private Rectangle rectangle;
        
        [TestInitialize]
        public void init()
        {
            rectangle = new Rectangle();
        }
        [TestMethod]
        public void In1x1ShouldAreaAreEqual1()
        {
            rectangle.X = 1.0;
            rectangle.Y = 1.0;
            Assert.AreEqual(1,rectangle.Area);
        }
        [TestMethod]
        public void In2x1ShouldAreaAreEqual2()
        {
            rectangle.X = 2.0;
            rectangle.Y = 1.0;
            Assert.AreEqual(2,rectangle.Area);
        }
        [TestMethod]
        public void In2x2ShouldAreaAreEqual4()
        {
            rectangle.X = 2.0;
            rectangle.Y = 2.0;
            Assert.AreEqual(4,rectangle.Area);
        }
        [TestMethod]
        public void In1x1ShouldPerimeterAreEqual4()
        {
            rectangle.X = 1.0;
            rectangle.Y = 1.0;
            Assert.AreEqual(4,rectangle.Perimeter);
        }
        [TestMethod]
        public void In2x1ShouldPerimeterAreEqual6()
        {
            rectangle.X = 2.0;
            rectangle.Y = 1.0;
            Assert.AreEqual(6,rectangle.Perimeter);
        }
        [TestMethod]
        public void In2x2ShouldPerimeterAreEqual8()
        {
            rectangle.X = 2.0;
            rectangle.Y = 2.0;
            Assert.AreEqual(8,rectangle.Perimeter);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InXset0OrLowerShouldThrownArgumentException()
        {
            rectangle.X = 0;
            rectangle.X = -1;

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InYset0OrLowerShouldThrownArgumentException()
        {
            rectangle.Y = 0;
            rectangle.Y = -1;

        }
    }
}
