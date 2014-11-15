using System.Xml;

namespace Kolo
{
    class Square : Rectangle
    {
        public Square(int a) : base(a, a)
        {
        }
    }
    class Rectangle
    {
        private int b;
        private int a;
        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Field()
        {
            return a * b;
        }

        public int Circuit()
        {
            return (2 * a) + (2 * b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
