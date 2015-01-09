using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    class Koszyk
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
                Console.WriteLine("Artykul zostal usuniety poprawnie");
                Console.ReadLine();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Podales bledny nr artykulu, powrot do Menu");
                Console.ReadLine();
                Console.Clear();
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
                Console.WriteLine("|=====================================================================================|");
                Console.WriteLine("|        Nazwa       |    Cena   | VAT|  Ilosc  |     Wartosc   |Rabat| Wartosc po rab|");
                Console.WriteLine("|=====================================================================================|");
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
                    string pusty = "";
                    for (int i = 0; i < 20 - nazwaDlugosc; i++)
                    {
                        pusty += " ";
                    }
                    string pusty2 = "";
                    for (int i = 0; i < 8 - cenaDlugosc; i++)
                    {
                        pusty2 += " ";
                    }
                    string pusty3 = "";
                    for (int i = 0; i < 2 - vatDlugosc; i++)
                    {
                        pusty3 += " ";
                    }
                    string pusty4 = "";
                    for (int i = 0; i < 4 - iloscDlugosc; i++)
                    {
                        pusty4 += " ";
                    }
                    string pusty5 = "";
                    wartosc = ((double)oProdukt.Cena * (double)oProdukt.KgIlosc) +
                        ((double)oProdukt.Cena * (double)oProdukt.KgIlosc * (double)oProdukt.VAT / (double)100);
                    double wartoscOkragla = Math.Round(wartosc, 2);
                    int wartoscZnaki = (int)wartoscOkragla;
                    for (int i = 0; i < 9 - wartoscZnaki.ToString().Length; i++)
                    {
                        pusty5 += " ";
                    }
                    string pusty6 = "";
                    for (int i = 0; i < 3 - rabatDlugosc; i++)
                    {
                        pusty6 += " ";
                    }
                    string pusty7 = "";
                    RabatProduktu rabacik = new RabatProduktu(wartoscOkragla, oProdukt.rabat);
                    double wartoscRabatu = Math.Round(rabacik.PoliczRabat(), 2);
                    int wartoscZnaki2 = (int)wartoscRabatu;
                    for (int i = 0; i < 9 - wartoscZnaki2.ToString().Length; i++)
                    {
                        pusty7 += " ";
                    }

                    Console.WriteLine("|{0}" + pusty + "|" + pusty2 + "{1} zl|" + pusty3 + "{2} %|"
                        + pusty4 + "{3} szt.|" + pusty5 + "{4:F2} zl|" + pusty6 + "{5} %|" + pusty7
                        + "{6:F2} zl|",
                        oProdukt.Nazwa, oProdukt.Cena, oProdukt.VAT, oProdukt.KgIlosc, wartoscOkragla
                        , oProdukt.rabat, wartoscRabatu);
                    suma += wartoscOkragla;
                    sumaRabat += wartoscRabatu;

                }
                rabatKosza.wartosc = sumaRabat;
                double sumaRabatCalyKosz = rabatKosza.PoliczRabat();
                string pusty8 = "";
                int sumaZnaki = (int)Math.Round(suma, 2);
                for (int i = 0; i < 9 - sumaZnaki.ToString().Length; i++)
                {
                    pusty8 += " ";
                }
                string pusty9 = "";
                int sumaRabatZnaki = (int)Math.Round(sumaRabat, 2);
                for (int i = 0; i < 9 - sumaRabatZnaki.ToString().Length; i++)
                {
                    pusty9 += " ";
                }
                Console.WriteLine("|=====================================================================================|");
                Console.WriteLine("                                      |    Suma :" + pusty8 + "{0:F2} zl| Suma:" + pusty9 + "{1:F2} zl|", suma, sumaRabat);
                Console.WriteLine("                                      |===============================================|");
                if (rabatKosza.procent != 0)
                {
                    string pusty = "";
                    for (int i = 0; i < 4 - rabatKosza.procent.ToString().Length; i++)
                    {
                        pusty += " ";
                    }
                    string pusty2 = "";
                    int rabatKoszaZnaki = (int)Math.Round(sumaRabatCalyKosz, 2);
                    
                    for (int i = 0; i < 9 - rabatKoszaZnaki.ToString().Length; i++)
                    {
                        pusty2 += " ";
                    }
                    Console.WriteLine("                                      | Rabat dla calego koszyka:" + pusty + "{0} %               |", rabatKosza.procent);
                    Console.WriteLine("                                      |===============================================|");
                    Console.WriteLine("                                                                | Suma:" + pusty2 + "{0:F2} zł|", sumaRabatCalyKosz);
                    Console.WriteLine("                                                                |=====================|");
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
