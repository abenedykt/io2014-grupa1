using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktury
{
    class Zamowienie
    {
        //pola klasy
        private List<Produkt> produkty;
        public List<Produkt> Produkty
        {
            get { return produkty; }
            set { produkty = value; }
        }

        private Produkt wybranyProdukt;
        public Produkt WybranyProdukt
        {
            get { return wybranyProdukt; }
            set { wybranyProdukt = value; }
        }

        private string nazwa;
        public string Nazwa
        {
            get { return nazwa; }
            set { nazwa = value; }
        }

        private double wartosc;
        public double Wartosc
        {
            get
            {
                wartosc = 0;
                foreach (Produkt prod in produkty) wartosc += prod.Cena*prod.Ilosc;
                return wartosc;
            }
      
        }

        private double rabat;
        public double Rabat
        {
            get
            {
                rabat = 0;
                foreach (Produkt prod in produkty) rabat += prod.Rabat*prod.Ilosc;
                return rabat;
            }
        }

        private double iloscProduktow;
        public double IloscProduktow
        {
            get
            {
                iloscProduktow = 0;
                foreach (Produkt prod in produkty) iloscProduktow += prod.Ilosc;
                return iloscProduktow;
            }
        }

        public Zamowienie(List<Produkt> Produkty, string Nazwa)
        {
            nazwa = Nazwa;
            produkty = Produkty;
        }

        public Zamowienie(string Nazwa)
        {
            nazwa = Nazwa;
            produkty = new List<Produkt>();
        }
    }
}
