using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzzTest
{
    class fb
    {
        public object gra(int parametr)
        {
            for (int liczba = 0; liczba <= 100; liczba++)
            {
                if (liczba % 15 == 0)
                {
                    Console.WriteLine(liczba + "FizzBuzz");
                }
                else if (liczba % 5 == 0)
                {
                    Console.WriteLine(liczba + "Fizz");
                }
                else if (liczba % 3 == 0)
                {
                    Console.WriteLine(liczba + "Buzz");
                }
            }
            return parametr;
        }
    }
}
