using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp.Test
{
    [TestClass]
    public class ProstokatTesty
    {
        [TestMethod]
        public void It_Should_Return_Correct_Rectangle_Area()
        {
            FiguraAbstrakcyjna prostokat = new Prostokat(4.0, 5.0);

            double area = prostokat.LiczPole();

            Assert.IsTrue(area == 20.0);
        }

        [TestMethod]
        public void It_Should_Return_Correct_Rectangle_Length()
        {
            FiguraAbstrakcyjna prostokat = new Prostokat(4.0, 5.0);

            double length = prostokat.LiczObwod();

            Assert.IsTrue(length == 18.0);
        }
    }
}
