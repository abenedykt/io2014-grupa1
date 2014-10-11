using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class fissBassGame
    {
        internal object play(int p)
        {
            return p;
        }

        internal object fizz(int p)
        {
            if (p % 3 == 0 && p % 5 != 0)
            {
                return "Fizz";
            }
            return 1;
        }

        internal object buzz(int p)
        {
            if (p % 5 == 0 && p % 3 != 0)
            {
                return "Buzz";
            }
            return 1;
        }

        internal object fizzbuzz(int p)
        {
            if (p % 5 == 0 && p % 3 == 0)
            {
                return "Fizz Buzz";
            }
            return 1;
        }
    }
}
