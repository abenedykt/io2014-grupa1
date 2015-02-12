using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktury
{
    class ListaZamowien : List<Zamowienie>
    {
        private Zamowienie wybraneZamowienie;
        public Zamowienie WybraneZamowienie
        {
            get { return wybraneZamowienie; }
            set { wybraneZamowienie = value; }
        }
    }
}
