using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;

namespace FizzBuzzGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe calkowita: ");
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine();

            var gra = new fissBassGame();

            Console.WriteLine(gra.play(x));
            Console.ReadKey();
        }
    }
}
