using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestInitialize]
        public void Init()
        {
            FizzBuzz = new FizzBuzzGame();
        }
        [TestMethod]
        public void In1Out1Test()
        {
            Assert.AreEqual(FizzBuzz.Play(1), "1");
        }
        [TestMethod]
        public void In3OutFizzTest()
        {
            Assert.AreEqual(FizzBuzz.Play(3), "Fizz");
        }
        [TestMethod]
        public void In5OutBuzzTest()
        {
            Assert.AreEqual(FizzBuzz.Play(5), "Buzz");
        }
        [TestMethod]
        public void In15OutFizzBuzzTest()
        {
            Assert.AreEqual(FizzBuzz.Play(15), "Fizz Buzz");
        }
        public FizzBuzzGame FizzBuzz { get; set; }
    }
}
