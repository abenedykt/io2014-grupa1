using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FigureField
{
    public class Tests
    {
        [Fact]
        public void RectangleFieldEquals50()
        {
            var rect = new Rectangle(5, 10);
            Assert.Equal(50, rect.GetField());
        }

        [Fact]
        public void RectangleLengthEquals30()
        {
            var rect = new Rectangle(5, 10);
            Assert.Equal(30, rect.GetLength());
        }

        [Fact]
        public void SquareFieldEquals25()
        {
            var sqr = new Square(5);
            Assert.Equal(25, sqr.GetField());
        }
    }
}
