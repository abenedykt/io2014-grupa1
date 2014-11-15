using Xunit;

namespace Kolo
{
    public class Tests
    {
        [Fact]
        public void SprawdzPoleProstokat()
        {
            var rectangle = new Rectangle(2,5);
            var result = rectangle.Field();
            Assert.Equal(10, result);
        }
        [Fact]
        public void SprawdzObwodProstokat()
        {
            var rectangle = new Rectangle(2, 5);
            var result = rectangle.Circuit();
            Assert.Equal(14, result);
        }
        [Fact]
        public void SprawdzPoleKwadrat()
        {
            var square = new Square(5);
            var result = square.Field();
            Assert.Equal(25, result);
        }
        [Fact]
        public void SprawdzObwodKwadrak()
        {
            var square = new Square(5);
            var result = square.Circuit();
            Assert.Equal(20, result);
        }

    }
}
