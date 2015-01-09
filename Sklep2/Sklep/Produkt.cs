using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    public class Produkt
    {
        public string Nazwa { get; set; }
        public double Cena { get; set; }
        public int VAT { get; set; }
        public double KgIlosc { get; set; }
        public int rabat { get; set; }

        public Produkt()
        {
        }

        public Produkt(string Nazwa, double Cena, int VAT, double KgIlosc)
        {
            this.Nazwa = Nazwa;
            this.Cena = Cena;
            this.VAT = VAT;
            this.KgIlosc = KgIlosc;
        }

        public Produkt(string Nazwa, double Cena, int VAT, double KgIlosc, int rabat)
        {
            this.Nazwa = Nazwa;
            this.Cena = Cena;
            this.VAT = VAT;
            this.KgIlosc = KgIlosc;
            this.rabat = rabat;
        }
    }
}
