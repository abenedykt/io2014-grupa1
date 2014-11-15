using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Liskov;

namespace LiskovTest
{
    [TestClass]
    public class RectangleTest
    {
        Rectangle rect;

        [TestInitialize]
        public void Init() 
        {
            rect = new Rectangle(2, 5);
        }

        [TestMethod]
        public void TestPerimiter()
        {
            Assert.AreEqual(14, rect.Perimiter());
        }

        [TestMethod]
        public void TestSpace() 
        {
            Assert.AreEqual(10, rect.Space());
        }
    }
}
