using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Test
{
    class Prostokąt
    {
        

        public Prostokąt(int bok1, int bok2) 
        {
           
            int pole = bok1 * bok2;
            int obwod = 2 * bok1 + 2 * bok2;
            Console.WriteLine("Pole prostokąta wynosi: " + pole);
            Console.WriteLine("Obwod prostokąta wynosi: " + obwod + "\n");
        }

      
        }
    class Kwadrat
    {


        public Kwadrat(int bok1)
        {

            int pole = bok1 * bok1;
            int obwod = 4 * bok1 ;
            Console.WriteLine("Pole kwadratu wynosi: " + pole);
            Console.WriteLine("Obwod kwadratu wynosi: " + obwod + "\n");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj bok prostokąta a: " );
           
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj bok prostokąta b: ");
            int b = int.Parse(Console.ReadLine());
            Prostokąt prostokat = new Prostokąt(a, b);
            Console.WriteLine("podaj bok kwadratu a: ");

            int bok = int.Parse(Console.ReadLine());
            Kwadrat kwadrat = new Kwadrat(bok);
            Console.ReadKey();
        }
    }
}