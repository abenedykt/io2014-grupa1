using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace fizzbuzzTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void Sprawdzenie_Zwracanej_Liczby()
        {
            var game = new fb();
            var result = game.gra(1);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Fizz()
        {
            var game = new fb();
            var result = game.gra(5);
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void Buzz()
        {
            var game = new fb();
            var result = game.gra(3);
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void FizzBuzz()
        {
            var game = new fb();
            var result = game.gra(15);
            Assert.AreEqual("FizzBuzz", result);
        }
    }
}
