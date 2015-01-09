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
            Console.WindowWidth = 100;
            Koszyk kosz = new Koszyk(); //tworzenie kosza zakupow
            RabatKosza rabatKosza = new RabatKosza(0, 0);
            
            ConsoleKeyInfo klawisz;
            do
            {
                Console.WriteLine("            Menu: ");
                Console.WriteLine("*=================================*");
                Console.WriteLine("*                                 *");
                Console.WriteLine("*1 - Doawanie towarow do kosza    *");
                Console.WriteLine("*2 - Usuwanie towarow z kosza     *");
                Console.WriteLine("*3 - Wyswietlanie zawartosci kosza*");
                Console.WriteLine("*                                 *");
                Console.WriteLine("*Q - Wyjscie z programu           *");
                Console.WriteLine("*                                 *");
                Console.WriteLine("*=================================*");


                klawisz = Console.ReadKey();
                if (klawisz.Key == ConsoleKey.D1)
                {
                    Dodawanie(kosz, rabatKosza);
                }
                if (klawisz.Key == ConsoleKey.D2)
                {
                    Usuwanie(kosz);
                }
                if (klawisz.Key == ConsoleKey.D3)
                {
                    Console.Clear();
                    kosz.Display(rabatKosza);
                    Console.ReadLine();
                }
                Console.Clear();
            } while (klawisz.Key != ConsoleKey.Q);



            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("Liczba przedmiotow w koszyku to: {0}", kosz.DisplayIlosc());
            Console.ReadLine();
        }

        public static void Dodawanie(Koszyk kosz, RabatKosza rabatKosza)
        {
            ConsoleKeyInfo czy;
            ConsoleKeyInfo czyRabat;
            double cena = 0;
            int vat;
            int rabat = 0;
            double ilosc = 0;
            do
            {
                Console.Clear();
                Console.Write("\nCzy chcesz dodac towar do koszyka? [T/N]");
                czy = Console.ReadKey();
                Console.Clear();
                if (czy.Key == ConsoleKey.T)
                {
                    Console.Write("\nNazwa (20): ");
                    var nazwa = Console.ReadLine();
                    if (nazwa.Length == 0)
                    {
                        Console.WriteLine("Nie podales nazwy produktu, powrot do menu");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                    else if (nazwa.Length > 20)
                    {
                        Console.WriteLine("Wprowadziles zbyt dluga nazwe, powrot do menu");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                    Console.Write("Cena (7): ");
                    try
                    {
                        cena = double.Parse(Console.ReadLine());
                        if (cena.ToString().Length > 7)
                        {
                            Console.WriteLine("Wprowadziles zbyt wysoka cene, powrot do menu");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                        if (cena == 0)
                        {
                            Console.WriteLine("Cena musi byc wieksza od 0, powrot do menu");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                        if (cena < 0)
                        {
                            Console.WriteLine("Cena musi byc wieksza od 0, powrot do menu");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Wprowadziles niepoprawna cene, wracamy do menu");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }
                    Console.Write("VAT (2): ");
                    try
                    {
                        vat = int.Parse(Console.ReadLine());
                        if (vat.ToString().Length > 2)
                        {
                            Console.WriteLine("Wprowadziles zbyt wysoki VAT, powrot do menu");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                        if (vat < 0)
                        {
                            Console.WriteLine("VAT nie moze byc ujemny, powrot do menu");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Wprowadziles niepoprawny VAT, wracamy do menu");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                    Console.Write("Ilosc(4): ");
                    try
                    {
                        ilosc = double.Parse(Console.ReadLine());
                        if (ilosc.ToString().Length > 4)
                        {
                            Console.WriteLine("Zbyt duza ilosc, powrot do menu");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                        if (ilosc < 0)
                        {
                            Console.WriteLine("Ilosc nie moze byc ujemna, powrot do menu");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Wprowadziles niepoprawna Ilosc, wracamy do menu");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                    Console.Write("Rabat(2): ");
                    try
                    {
                        rabat = int.Parse(Console.ReadLine());
                        if (rabat.ToString().Length > 2)
                        {
                            Console.WriteLine("Wprowadziles zbyt wysoki Rabat, powrot do menu");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                        if (rabat < 0)
                        {
                            Console.WriteLine("Rabat nie moze byc ujemny, powrot do menu");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Wprowadziles niepoprawny Rabat, wracamy do menu");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                    kosz.Dodaj(nazwa, cena, vat, ilosc, rabat);
                }
            }
            while (czy.Key != ConsoleKey.N);

            do
            {
                Console.Clear();
                Console.WriteLine("Czy chcesz dodac rabat na caly kosz ? [T/N]");
                czyRabat = Console.ReadKey();

                bool jest = false;
                if (czyRabat.Key == ConsoleKey.T)
                {
                    Console.Clear();
                    if (kosz.koszyk.Count == 0)
                    {
                        Console.WriteLine("Koszyk jest pusty, nie mozna dodac rabatu, powrot do menu. ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }

                    Console.Write("Wprowadz rabat(2): ");
                    try
                    {
                        rabatKosza.procent = int.Parse(Console.ReadLine());
                        if (rabatKosza.procent.ToString().Length > 2)
                        {
                            Console.WriteLine("Wprowadziles zbyt wysoki rabat, powrot do menu");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                        if (rabatKosza.procent < 0)
                        {
                            Console.WriteLine("Rabat nie moze byc ujemny, powrot do menu");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Wprowadziles niepoprawny rabat, wracamy do menu");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }
                    jest = true;
                }
                if (jest == true)
                {
                    break;
                }
            }
            while (czyRabat.Key != ConsoleKey.N);
        }

        public static void Usuwanie(Koszyk kosz)
        {
            Console.Clear();
            Console.WriteLine("Liczba przedmiotow w koszyku to: {0}", kosz.DisplayIlosc());
            Console.WriteLine("Podaj nr artykulu do usuniecia z kosza: ");
            Console.WriteLine();

            var index = int.Parse(Console.ReadLine());
            kosz.Usun(--index);
        }
    }
}
