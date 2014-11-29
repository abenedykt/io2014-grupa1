using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    class Zamowienie : Produkt
    {
        public float CenaDostawy { get; set; }
        public float RabatZamowienia { get; set; }
        List<Produkt> Koszyk = new List<Produkt>();
        public void DodajProdukt(Produkt p)
        {
            Koszyk.Add(p);
        }
        
    }
}
