using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{

    class Prostokat {

        public static int BokA;
        public static int BokB;
        public static void PoleProstokata(){
            Console.WriteLine(BokA*BokB);
        }
        public static void ObwodProstokata() {
            Console.WriteLine(2*(BokA+BokB));
        }
        public static void PodajBokiKwadratu(int BokJeden, int BokDwa) {
            BokA = BokJeden;
            BokB = BokDwa;
        }

    }



    class Kwadrat
    {

        public static int BokA;
        public static void PoleProstokata()
        {
            Console.WriteLine(BokA * BokA);
        }
        public static void ObwodProstokata()
        {
            Console.WriteLine(2*BokA);
        }
        public static void PodajBokiKwadratu(int BokJeden)
        {
            BokA = BokJeden;
        }

    }


    class Program
    {

        static void Main(string[] args)
        {
           
        }
    }
}
