using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sklep
{
    class Program
    {

        #region MenuGlowne

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            
            Koszyk kosz = new Koszyk(); //tworzenie kosza zakupow
            RabatKosza rabatKosza = new RabatKosza(0, 0);
            
            ConsoleKeyInfo klawisz;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Doawanie towarow do kosza");
                Console.WriteLine("2 - Usuwanie towarow z kosza");
                Console.WriteLine("3 - Wyswietlanie zawartosci kosza");
                Console.WriteLine("Q - Wyjscie z programu");



                klawisz = Console.ReadKey();

                switch (klawisz.Key)
                {
                    case ConsoleKey.D1:
                        Dodawanie(kosz, rabatKosza);
                        break;

                    case ConsoleKey.D2:
                        Usuwanie(kosz);
                        break;
                    case ConsoleKey.D3:
                        kosz.Display(rabatKosza);
                        Console.ReadLine();
                        break;
                }

            } while (klawisz.Key != ConsoleKey.Q);
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine("dziekujemy za uzycie naszego programu");
        }

        #endregion

        #region Usuwanie z koszyka
        public static void Usuwanie(Koszyk kosz)
        {
            Console.Clear();
            Console.WriteLine("Liczba przedmiotow w koszyku to: {0}", kosz.DisplayIlosc());
            Console.WriteLine("Podaj nr artykulu do usuniecia z kosza: ");
            Console.WriteLine();

            var index = int.Parse(Console.ReadLine());
            kosz.Usun(--index);
        }

        #endregion 

        public static void Dodawanie(Koszyk koszykklienta, RabatKosza RabatKoszyka)
        {
            ConsoleKeyInfo DodacDoKosza;
            ConsoleKeyInfo czyRabat;
            double cena = 0;
            int vat;
            int rabat = 0;
            double ilosc = 0;
            
            do
            {
                Console.WriteLine("Dodac towar do koszyka Tak/Nie");
                DodacDoKosza = Console.ReadKey();
                Console.WriteLine();

                if (DodacDoKosza.Key == ConsoleKey.T)
                {
                    Console.WriteLine();
                    Console.WriteLine("Podaj nazwe towaru: ");
                    var nazwa = Console.ReadLine();
                    if (nazwa.Length == 0)
                    {
                        Console.WriteLine("Nie podales nazwy produktu, powrot do menu");
                        Console.ReadLine();
                        continue;
                    }

                    Console.WriteLine("Podaj cene produktu, aby podac grosze uzyj , ");
                    try
                    {
                        cena = double.Parse(Console.ReadLine());
                       
                        if (cena == 0)
                        {
                            Console.WriteLine("Cena musi byc wieksza od 0, powrot do menu");
                            Console.ReadLine();
                            continue;
                        }
                        if (cena < 0)
                        {
                            Console.WriteLine("Cena musi byc wieksza od 0, powrot do menu");
                            Console.ReadLine();
                            continue;
                        }

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Wprowadziles niepoprawna cene, sprobuj uzyc znaku , ");
                        Console.WriteLine("Powrot do menu");
                        Console.ReadLine();
                        continue;
                    }
                    Console.WriteLine("Podaj stawke VAT produktu");
                    try
                    {
                        vat = int.Parse(Console.ReadLine());
                        if (vat.ToString().Length > 2)
                        {
                            Console.WriteLine("VAT nie moze przekroczyc 99 % sprobuj ponownie");
                            Console.WriteLine("Powrot do menu");
                            Console.ReadLine();
                            continue;
                        }
                        if (vat < 0)
                        {
                            Console.WriteLine("VAT nie może być mniejszy od 0, sprubuj ponownie");
                            Console.WriteLine("Powrot do menu");
                            Console.ReadLine();
                            continue;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Wprowadziles niepoprawna wartosc, sprobuj uzyc znaku , ");
                        Console.ReadLine();
                        continue;
                    }

                    Console.WriteLine("Podaj ilosc sprzedawanych produktow ");
                    try
                    {
                        ilosc = double.Parse(Console.ReadLine());

                        if (ilosc < 0)
                        {
                            Console.WriteLine("Ilosc nie moze byc mniejsza niz 0");
                            Console.WriteLine("jesli chcesz odjac z koszyka uzyj metody Usun Produkt");
                            Console.ReadLine();
                            continue;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Wprowadziles niepoprawna Ilosc");
                        Console.WriteLine("Powrot do menu");
                        Console.ReadLine();
                        continue;
                    }

                    Console.WriteLine("Wprowadz rabat na produkt dla danego klienta w procentach ");
                    try
                    {
                        rabat = int.Parse(Console.ReadLine());
                        if (rabat.ToString().Length > 2)
                        {
                            Console.WriteLine("Nie ma nic za darmo, rabat musi byc mniejszy niz 100 %");
                            Console.WriteLine("Powrot do menu");
                            Console.ReadLine();
                            continue;
                        }
                        if (rabat < 0)
                        {
                            Console.WriteLine("Rabat nie moze byc ujemny");
                            Console.WriteLine("Powrot do menu");
                            Console.ReadLine();
                            continue;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Wprowadziles niepoprawny Rabat, musi to byc liczba calkowita");
                        Console.WriteLine("Powrot do menu");
                        Console.ReadLine();
                        continue;
                    }

                    koszykklienta.Dodaj(nazwa, cena, vat, ilosc, rabat);
                }
            }
            while (DodacDoKosza.Key != ConsoleKey.N);

            do
            {
                Console.Clear();
                Console.WriteLine("Czy chcesz dodac rabat na caly kosz ? [T/N]");
                czyRabat = Console.ReadKey();

                bool jest = false;
                if (czyRabat.Key == ConsoleKey.T)
                {
                    Console.Clear();
                    if (koszykklienta.koszyk.Count == 0)
                    {
                        Console.WriteLine("Koszyk jest pusty, nie mozna dodac rabatu, powrot do menu. ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }

                    Console.Write("Wprowadz rabat(2): ");
                    try
                    {
                        RabatKoszyka.procent = int.Parse(Console.ReadLine());
                        if (RabatKoszyka.procent.ToString().Length > 2)
                        {
                            Console.WriteLine("Wprowadziles zbyt wysoki rabat, powrot do menu");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                        if (RabatKoszyka.procent < 0)
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


       
    }
}
