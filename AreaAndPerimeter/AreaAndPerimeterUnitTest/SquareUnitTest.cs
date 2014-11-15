using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaAndPerimeter;

namespace AreaAndPerimeterUnitTest
{
    [TestClass]
    public class SquareUnitTest
    {
        private Square square;
        
        [TestInitialize]
        public void init()
        {
            square = new Square();
        }
        [TestMethod]
        public void In1ShouldAreaAreEqual1()
        {
            square.X = 1.0;
            Assert.AreEqual(1,square.Area);
        }
        [TestMethod]
        public void In2ShouldAreaAreEqual4()
        {
            square.X = 2.0;
            Assert.AreEqual(4, square.Area);
        }
        [TestMethod]
        public void In1ShouldPerimeterAreEqual4()
        {
            square.X = 1.0;
            Assert.AreEqual(4, square.Perimeter);
        }
        [TestMethod]
        public void In2ShouldPerimeterAreEqual8()
        {
            square.X = 2.0;
            Assert.AreEqual(8, square.Perimeter);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void In0OrLowerShouldThrownArgumentException()
        {
            square.X = 0;
            square.X = -1;
        }

        
    }
}
