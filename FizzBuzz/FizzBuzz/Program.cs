using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzz
{
    class Game
    {
        public object play(int input)
        {
            if(input % 15 == 0)
                return "FizzBuzz";
            else if (input % 5 == 0)
                return "Buzz";
            else if (input % 3 == 0)
                return "Fizz";
            
            return input;
        }
    }
    public class Program
    {
        [Fact]
        public void FirstRunTest()
        {
            Assert.Equal(true, true);  
        }

        [Fact]
        public void IfOneExpectOne()
        {
            Game game = new Game();
            var result = game.play(1);
            
            Assert.Equal(1, result);
        }

        [Fact]
        public void IfThreeExpectFizz()
        {
            Game game = new Game();
            var result = game.play(3);

            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void IfFiveExpectFizz()
        {
            Game game = new Game();
            var result = game.play(5);

            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void If15ExpectFizz()
        {
            Game game = new Game();
            var result = game.play(15);

            Assert.Equal("FizzBuzz", result);
        }
        static void Main(string[] args)
        {
            Game game = new Game();
            while(true)
            {
                Console.Write("Input a number: ");
                Console.WriteLine("The result is " + game.play(Int32.Parse(Console.ReadLine())));
            }
        }
    }
}
