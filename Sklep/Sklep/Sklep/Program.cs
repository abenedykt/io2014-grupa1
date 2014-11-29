using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    class Program
    {
        static void Main(string[] args)
        {
            Zamowienie t = new Zamowienie();
            t.DodajProdukt(new Produkt("dlugopis", 2.32f, 23));
        }
    }
}
