using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzzGame
    {
        
        public object gra(int x)
        {
            
            if (x % 3 == 0 && x % 5 != 0) return "Fizz";
            else if (x % 5 == 0 && x % 3 != 0) return "Buzz";
            else if (x % 3 == 0 && x % 3 == 0) return "FizzBuzz";
            else return x;
        }
    }
}
