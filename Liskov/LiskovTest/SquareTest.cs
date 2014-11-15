using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Liskov;

namespace LiskovTest
{
    [TestClass]
    public class SquareTest
    {
        Square square;
        [TestInitialize]
        public void Init() 
        {
            square = new Square(2);
        }

        [TestMethod]
        public void TestPerimiter()
        {
            Assert.AreEqual(8, square.Perimiter());
        }

        [TestMethod]
        public void TestSpace()
        {
            Assert.AreEqual(4, square.Space());
        }
    }
}
