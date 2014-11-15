using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FigureField
{
    class Rectangle
    {
        protected double a, b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double GetField()
        {
            return a * b;
        }

        public double GetLength()
        {
            return (a * 2) + (b * 2);
        }
    }

    class Square : Rectangle
    {
        public Square(double a) : base(a, a) { }
    }

    class Tests
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

    class Program
    {
        static void Main(string[] args)
        {
            var rect = new Rectangle(5, 10);
            Console.WriteLine(rect.GetField());
            Console.WriteLine(rect.GetLength());

            rect = new Square(10);
            Console.WriteLine(rect.GetField());
            Console.WriteLine(rect.GetLength());
        }
    }
}
