using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FiguraAbstrakcyjna kwadrat = new Kwadrat(4.0);
            Show(kwadrat.LiczObwod());
            Show(kwadrat.LiczPole());

            FiguraAbstrakcyjna prostokat = new Prostokat(3.0, 4.0);
            Show(prostokat.LiczObwod());
            Show(prostokat.LiczPole());

            Console.ReadKey();
        }

        static void Show(double value)
        {
            Console.WriteLine(value);
        }
    }
}
