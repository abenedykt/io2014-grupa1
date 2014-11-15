using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp;

namespace ConsoleApp.Test
{
    [TestClass]
    public class KwadratTesty
    {
        [TestMethod]
        public void It_Should_Return_Correct_Square_Area()
        {
            FiguraAbstrakcyjna kwadrat = new Kwadrat(4.0);

            double area = kwadrat.LiczPole();

            Assert.IsTrue(area == 16.0);
        }

        [TestMethod]
        public void It_Should_Return_Correct_Square_Length()
        {
            FiguraAbstrakcyjna kwadrat = new Kwadrat(4.0);

            double length = kwadrat.LiczObwod();

            Assert.IsTrue(length == 16.0);
        }
    }
}
