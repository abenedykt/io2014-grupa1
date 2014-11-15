using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    public class Rectangle
    {
        public double A {get; private set;}
        public double B {get; private set;}

        public Rectangle(double A, double B)
        {
            this.A = A;
            this.B = B;
        }

        public virtual double Perimiter() 
        {
            return 2 *(A + B);
        }

        public virtual double Space() 
        {
            return A * B;
        }
    }

    public class Square : Rectangle
    {
        public Square(double A): base(A,A){}
    }

    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(2, 5);
            var square = new Square(2);

            Console.WriteLine("Perimiter Rect : {0}", rectangle.Perimiter());
            Console.WriteLine("Space Rect: {0}", rectangle.Space());

            Console.WriteLine("Perimiter Square {0}", square.Perimiter());
            Console.WriteLine("Space Square {0}", square.Space());
        }
    }
}
