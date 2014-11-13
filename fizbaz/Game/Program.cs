using System;
using FizBazz;

namespace Game
{
    class Program
    {
        static void Main()
        {
            var game = new FizzBazzGame();
            int i = 1;
            Console.WriteLine("FizzBazz Game");
            do
            {       
                if (Console.ReadLine() != game.Play(i).ToString()) break;
                i++;
            } while (true);
            Console.WriteLine("Game Over!");
            
        }
    }
}
