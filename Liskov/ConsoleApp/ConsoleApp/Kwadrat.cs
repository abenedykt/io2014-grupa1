using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Kwadrat : FiguraAbstrakcyjna
    {
        public Kwadrat(double bokA)
            : base(bokA)
        { }

        public override double LiczPole()
        {
            return this.BokA * this.BokA;
        }

        public override double LiczObwod()
        {
            return 4 * this.BokA;
        }
    }
}
