using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    abstract class Rabat
    {
        protected double wartosc {get; set;}
        protected double procent {get; set;}

        public Rabat(double wartosc, double procent)
        {
            this.wartosc = wartosc;
            this.procent = procent;
        }

        abstract public double PoliczRabat();
    }
}
