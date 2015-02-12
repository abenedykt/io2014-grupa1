using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktury
{
    class Produkt
    {
        private string nazwa;
        public string Nazwa
        {
            get { return nazwa; }
            set { nazwa = value; }
        }

        private double cena;
        public double Cena
        {
            get { return cena; }
            set { cena = value; }
        }

        private double vat;
        public double Vat
        {
            get { return vat; }
            set { vat = value; }
        }

        private double rabat;
        public double Rabat
        {
            get { return rabat; }
            set { rabat = value; }
        }

        private double ilosc;
        public double Ilosc
        {
            get { return ilosc; }
            set { ilosc = value; }
        }

        public Produkt(string Nazwa, double Ilosc, double Cena, double Vat, double Rabat)
        {
            nazwa = Nazwa;
            ilosc = Ilosc;
            cena = Cena;
            vat = Vat;
            rabat = Rabat;
        }

    }
}
