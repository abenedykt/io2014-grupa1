using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzz
{
    public class TClass
    {
        [Fact]
        public void TestJeden()
        {
            Assert.Equal(true, true);
        }

        [Fact]
        public void SprRet()
        {
            var game = new FizBazGame();
            var result = game.play(1);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Fizz()
        {
            var game = new FizBazGame();
            var result = game.fiz(3);
            Assert.Equal("Fiz", result);
        }

        [Fact]
        public void Buz()
        {
            var game = new FizBazGame();
            var result = game.buz(5);
            Assert.Equal("Buz", result);
        }

        [Fact]
        public void FizzBuzz()
        {
            var game = new FizBazGame();
            var result = game.fizbuz(15);
            Assert.Equal("Fiz Buz", result);
        }
    }
}
