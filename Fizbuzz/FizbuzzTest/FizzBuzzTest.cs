using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzLib;


namespace FizbuzzTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void If_I_Put_1_I_Shoud_Get_1_Test()
        { 
            var game = new FizzBuzzGame();
            var play = game.Play(1);
            Assert.AreEqual("1", play);
        }

        [TestMethod]
        public void If_I_Put_3_I_Shoud_Get_Fizz_Test()
        {
            var game = new FizzBuzzGame();
            var play = game.Play(3);
            Assert.AreEqual("Fizz", play);
        }

        [TestMethod]
        public void If_I_Put_5_I_Shoud_Get_Fizz_Test()
        {
            var game = new FizzBuzzGame();
            var play = game.Play(5);
            Assert.AreEqual("Buzz", play);
        }

        [TestMethod]
        public void If_I_Put_15_I_Shoud_Get_FizzBuzz_Test()
        {
            var game = new FizzBuzzGame();
            var play = game.Play(15);
            Assert.AreEqual("FizzBuzz", play);
        }
    }
}
