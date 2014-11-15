using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public abstract class FiguraAbstrakcyjna
    {
        public double BokA { get; set; }

        public double BokB { get; set; }

        public FiguraAbstrakcyjna(double bokA)
        {
            this.BokA = bokA;
        }

        public FiguraAbstrakcyjna(double bokA, double bokB) : this(bokA)
        {
            this.BokB = bokB;
        }

        public abstract double LiczPole();
        public abstract double LiczObwod();
    }
}
