using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Prostokat : FiguraAbstrakcyjna
    {
        public Prostokat(double bokA, double bokB)
            : base(bokA, bokB)
        { }

        public override double LiczPole()
        {
            return this.BokA * this.BokB;
        }

        public override double LiczObwod()
        {
            return 2 * this.BokA + 2 * this.BokB;
        }
    }
}
