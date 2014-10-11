using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzz
{
    public class Class1
    {
        [Fact]
       public void PierwszyTest()
        {
            var game = new FizzBuzzGame();
            var result = game.gra(1);
            Assert.Equal(1, result);
        }
        
        [Fact]
        public void DrugiTest()
        {
            var game = new FizzBuzzGame();
            var result = game.gra(45);
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void TrzeciTest()
        {
            var game = new FizzBuzzGame();
            var result = game.gra(4);
            Assert.Equal(4, result);
        }

        [Fact]
        public void CzwartyTest()
        {
            var game = new FizzBuzzGame();
            var result = game.gra(6);
            Assert.Equal("Fizz", result);
        }
        [Fact]
        public void PiatyTest()
        {
            var game = new FizzBuzzGame();
            var result = game.gra(10);
            Assert.Equal("Buzz", result);
        }

    }
}
