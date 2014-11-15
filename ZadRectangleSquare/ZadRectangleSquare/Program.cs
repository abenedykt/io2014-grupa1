using System;

namespace ZadRectangleSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(2, 3);

            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.CalculateCircuit());

            Square square = new Square(2);

            Console.WriteLine(square.CalculateArea());
            Console.WriteLine(square.CalculateCircuit());
        }
    }
}
