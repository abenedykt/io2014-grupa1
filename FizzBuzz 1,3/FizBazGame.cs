using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class FizBazGame
    {
        internal object play(int p)
        {
            return p;
        }

        internal object fiz(int p)
        {
            if (p % 3 == 0 && p % 5 != 0)
            {
                return "Fiz";
            }
            return 1;
        }

        internal object buz(int p)
        {
            if (p % 5 == 0 && p % 3 != 0)
            {
                return "Buz";
            }
            return 1;
        }

        internal object fizbuz(int p)
        {
            if (p % 5 == 0 && p % 3 == 0)
            {
                return "FizBuz";
            }
            return 1;
        }
    }
}
