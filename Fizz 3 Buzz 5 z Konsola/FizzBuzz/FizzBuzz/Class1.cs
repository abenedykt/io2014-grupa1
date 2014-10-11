using FizzBuzzGame;
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
            Assert.Equal(true, true);
        }

        [Fact]
        public void Sprawdzenie_Zwracanej_Liczby()
        {
            var game = new fissBassGame();
            var result = game.play(1);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Fizz()
        {
            var game = new fissBassGame();
            var result = game.play(3);
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Buzz()
        {
            var game = new fissBassGame();
            var result = game.play(5);
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void FizzBuzz()
        {
            var game = new fissBassGame();
            var result = game.play(15);
            Assert.Equal("Fizz Buzz", result);
        }
    }
}
