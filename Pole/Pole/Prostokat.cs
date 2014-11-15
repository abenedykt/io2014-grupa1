using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pole
{
    public class Prostokat
    {
        public int a {get; set;}
        public int b { get; set; }

        public Prostokat(int p1, int p2)
        {
             a = p1;
             b = p2;
        }

        public double Pole()
        {
            return a * b;
        }

        public double Obwod()
        {
            return 2 * a + 2 * b;
        }
        
    }
}
