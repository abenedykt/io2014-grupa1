using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    class Produkt
    {
        public string Nazwa { get; set; }
        public float Cena { get; set; }
        public int Vat { get; set; }
        public float Rabat { get; set; }

        public Produkt(string n, float c, int v)
        {
            Nazwa = n;
            Cena = c;
            Vat = v;
        }

        public Produkt(string n, float c)
        {
            Nazwa = n;
            Cena = c;
        }
    }
}
