using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public object Play(int p)
        {
            if (p % 3 == 0)
            {
                if (p % 5 == 0)
                {
                    return "Fizz Buzz";
                }
                return "Fizz";
            }
            else if (p % 5 == 0)
            {
                return "Buzz";
            }
            return p.ToString();
        }
    }
}
