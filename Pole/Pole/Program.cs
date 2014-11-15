using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj bok a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj bok b: ");
            int b = int.Parse(Console.ReadLine());
            Kwadrat  kwadrat1 = new Kwadrat(a);
            Console.WriteLine("Pole Kwadratu dla boku a wynosi: {0}", kwadrat1.Pole());
            Console.WriteLine("Obwod Kwadratu dla boku a wynosi: {0}", kwadrat1.Obwod());
            Prostokat prostoka1 = new Prostokat(a,b);
            Console.WriteLine("Pole Prostokatu wynosi: {0}", prostoka1.Pole());
            Console.WriteLine("Obwod Prostokatu wynosi: {0}", prostoka1.Obwod());

            Console.ReadLine();
        }
    }
}
