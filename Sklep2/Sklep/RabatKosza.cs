using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    class RabatKosza : Rabat
    {
        public double wartosc { get; set; }
        public double procent { get; set; }

        public RabatKosza(double wartosc, double procent)
            : base(wartosc, procent)
        { }

        public override double PoliczRabat()
        {
            double poRabacie = wartosc - (wartosc * procent / (100d));
            return poRabacie;
        }
    }
}
