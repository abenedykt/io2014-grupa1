using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    class ViewKoszyk
    {
        public List<Produkt> koszyk = new List<Produkt>();

        public void Dodaj(string Nazwa, double Cena, int VAT, double KgIlosc, int rabat)
        {
            Produkt dodawany = new Produkt(Nazwa, Cena, VAT, KgIlosc, rabat);
            koszyk.Add(dodawany);
        }

        public void Usun(int index)
        {
            try
            {
                koszyk.RemoveAt(index);
                Console.WriteLine("Artykul zostal usuniety z koszyka");
                Console.ReadLine();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Podales bledny nr artykulu");
                Console.WriteLine("Powrot do menu");
                Console.ReadLine();
            }
        }

        public void Display(RabatKosza rabatKosza)
        {

            if (koszyk.Count == 0)
            {
                Console.WriteLine("Koszyk pusty");
            }
            else
            {

                Console.WriteLine("Zawartosc kosza");
                Console.WriteLine();
                Console.WriteLine("   Nazwa               Cena    VAT  Ilosc       Wartosc   Rabat  Wartosc po rabacie");
                double suma = 0;
                double sumaRabat = 0;
                foreach (Produkt oProdukt in koszyk)
                {
                    int nazwaDlugosc = oProdukt.Nazwa.ToString().Length;
                    int cenaDlugosc = oProdukt.Cena.ToString().Length;
                    int vatDlugosc = oProdukt.VAT.ToString().Length;
                    int iloscDlugosc = oProdukt.KgIlosc.ToString().Length;
                    int rabatDlugosc = oProdukt.rabat.ToString().Length;
                    double wartosc;
                    string przerwa = "";
                    for (int i = 0; i < 20 - nazwaDlugosc; i++)
                    {
                        przerwa += " ";
                    }
                    string PrzerwaDwa = "";
                    for (int i = 0; i < 8 - cenaDlugosc; i++)
                    {
                        PrzerwaDwa += " ";
                    }
                    string PrzerwaTrzy = "";
                    for (int i = 0; i < 2 - vatDlugosc; i++)
                    {
                        PrzerwaTrzy += " ";
                    }
                    string PrzerwaCztery = "";
                    for (int i = 0; i < 4 - iloscDlugosc; i++)
                    {
                        PrzerwaCztery += " ";
                    }
                    string PrzerwaPiec = "";
                    wartosc = ((double)oProdukt.Cena * (double)oProdukt.KgIlosc) +
                        ((double)oProdukt.Cena * (double)oProdukt.KgIlosc * (double)oProdukt.VAT / (double)100);
                    double wartoscOkragla = Math.Round(wartosc, 2);
                    int wartoscZnaki = (int)wartoscOkragla;
                    for (int i = 0; i < 9 - wartoscZnaki.ToString().Length; i++)
                    {
                        PrzerwaPiec += " ";
                    }
                    string PrzerwaSzesc = "";
                    for (int i = 0; i < 3 - rabatDlugosc; i++)
                    {
                        PrzerwaSzesc += " ";
                    }
                    string PrzerwaSiedem = "";
                    RabatProduktu rabacik = new RabatProduktu(wartoscOkragla, oProdukt.rabat);
                    double wartoscRabatu = Math.Round(rabacik.PoliczRabat(), 2);
                    int wartoscZnaki2 = (int)wartoscRabatu;
                    for (int i = 0; i < 9 - wartoscZnaki2.ToString().Length; i++)
                    {
                        PrzerwaSiedem += " ";
                    }

                    Console.WriteLine("|{0}" + przerwa + "|" + PrzerwaDwa + "{1} zl|" + PrzerwaTrzy + "{2} %|"
                        + PrzerwaCztery + "{3} szt.|" + PrzerwaPiec + "{4:F2} zl|" + PrzerwaSzesc + "{5} %|" + PrzerwaSiedem
                        + "{6:F2} zl|",
                        oProdukt.Nazwa, oProdukt.Cena, oProdukt.VAT, oProdukt.KgIlosc, wartoscOkragla
                        , oProdukt.rabat, wartoscRabatu);
                    suma += wartoscOkragla;
                    sumaRabat += wartoscRabatu;

                }
                rabatKosza.wartosc = sumaRabat;
                double sumaRabatCalyKosz = rabatKosza.PoliczRabat();
                string PrzerwaOsiem = "";
                int sumaZnaki = (int)Math.Round(suma, 2);
                for (int i = 0; i < 9 - sumaZnaki.ToString().Length; i++)
                {
                    PrzerwaOsiem += " ";
                }
                string PrzerwaDziewiec = "";
                int sumaRabatZnaki = (int)Math.Round(sumaRabat, 2);
                for (int i = 0; i < 9 - sumaRabatZnaki.ToString().Length; i++)
                {
                    PrzerwaDziewiec += " ";
                }

                Console.WriteLine("Suma :" + PrzerwaOsiem + "{0:F2} zl| Suma:" + PrzerwaDziewiec + "{1:F2} zl|", suma, sumaRabat);
                if (rabatKosza.procent != 0)
                {
                    string Kp = "";
                    for (int i = 0; i < 4 - rabatKosza.procent.ToString().Length; i++)
                    {
                        Kp += " ";
                    }
                    string Kpp = "";
                    int rabatKoszaZnaki = (int)Math.Round(sumaRabatCalyKosz, 2);
                    
                    for (int i = 0; i < 9 - rabatKoszaZnaki.ToString().Length; i++)
                    {
                        Kpp += " ";
                    }
                    Console.WriteLine("Rabat dla calego koszyka:" + Kp + "{0} % ", rabatKosza.procent);
                    Console.WriteLine("Suma:" + Kpp + "{0:F2} zł|", sumaRabatCalyKosz);
                }
            }
        }

        public int DisplayIlosc()
        {
            int ile = koszyk.Count();
            return ile;
        }
    }
}
