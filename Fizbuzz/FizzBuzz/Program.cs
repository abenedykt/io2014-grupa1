using FizzBuzzLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string quit = string.Empty;
            Console.WriteLine("Witaj W FizzBuzz The Game");
            do
            {
                Console.WriteLine("Podaj jakąś liczbę");
                var input = int.Parse(Console.ReadLine());
                var game = new FizzBuzzGame();
                var output = game.Play(input);
                Console.WriteLine("Twoj wynik to {0}", output);
                Console.WriteLine("Czy chcesz grać dalej y/n");
                quit = Console.ReadLine();
            } while (quit == "y" || quit == "Y");
        }
    }
}
