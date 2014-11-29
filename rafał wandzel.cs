using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wystawianie_faktur
{



    class produkt
    {
        int id { get; set; }
        string nazwa { get; set; }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            float Cena = 800;
            Console.WriteLine("Twoje zamowienie zawiera : okno");
            Console.WriteLine("Wpisz vat ");
            float Vat1 = float.Parse(Console.ReadLine());
            float zamowienie = (Vat1/100)* Cena;
            Console.WriteLine("Twoje zamówienie wynosi : {0}", zamowienie);

        }


               
    }
}
