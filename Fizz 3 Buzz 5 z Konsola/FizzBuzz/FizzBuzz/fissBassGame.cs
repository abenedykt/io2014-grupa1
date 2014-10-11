using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzGame
{
    public class fissBassGame
    {
        public object play(int p)
        {
            if (p % 3 == 0 && p % 5 != 0)
            {
                return "Fizz";
            }
            else if (p % 5 == 0 && p % 3 != 0)
            {
                return "Buzz";
            }

            else if (p % 5 == 0 && p % 3 == 0)
            {
                return "Fizz Buzz";
            }
            else
            return p;
        }
    }
}
