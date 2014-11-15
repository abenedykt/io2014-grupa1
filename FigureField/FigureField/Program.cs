using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
