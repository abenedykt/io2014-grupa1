using Xunit;

namespace FizBazz
{
    public class Class1
    {
        [Fact]
        public void SprawdzCzyLiczba()
        {
            var game = new FizzBazzGame();
            var result = game.Play(1);
            Assert.Equal(1, result);
        }
        [Fact]
        public void SprawdzFizz()
        {
            var game = new FizzBazzGame();
            var result = game.Play(3);
            Assert.Equal("Fizz", result);
        }
        [Fact]
        public void SprawdzBazz()
        {
            var game = new FizzBazzGame();
            var result = game.Play(5);
            Assert.Equal("Bazz", result);
        }
        [Fact]
        public void SprawdzFizzBazz()
        {
            var game = new FizzBazzGame();
            var result = game.Play(15);
            Assert.Equal("FizzBazz", result);
        }
        [Fact]
        public void Sprawdz9()
        {
            var game = new FizzBazzGame();
            var result = game.Play(9);
            Assert.Equal("Fizz", result);
        }
        [Fact]
        public void Sprawdz20()
        {
            var game = new FizzBazzGame();
            var result = game.Play(20);
            Assert.Equal("Bazz", result);
        }
        [Fact]
        public void Sprawdz45()
        {
            var game = new FizzBazzGame();
            var result = game.Play(45);
            Assert.Equal("FizzBazz", result);
        }
    }
}

