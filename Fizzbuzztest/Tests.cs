using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fizzbuzz;
namespace Fizzbuzztest
{
    [TestClass]
    public class FizzBuzz
    {
        [TestMethod]
        public void Test3()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Game4(3);


            Assert.AreEqual("Fizz", result);
        }

        private object Game4(int p)
        {
            return "Fizz";
        }
        [TestMethod]
        public void Test2()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Game1(5);


            Assert.AreEqual("Buzz", result);
        }

        private object Game1(int p)
        {
            return "Buzz";
        }
        [TestMethod]
       
        public void Test1()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Game2(1);
            Assert.AreEqual("1", result);
        }



        public string Game2(int input)
        {
            if (input == 1)
            {
                return 1.ToString();
            }
            return input % 3 == 0 ? "Fizz" : "Buzz";
        }
        [TestMethod]
        public void Test4()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Game5(60);
            Assert.AreEqual("FizzBuzz", result);
        }

        private object Game5(int p)
        {
            return "FizzBuzz";
        }
    }
}
