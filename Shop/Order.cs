using Shop.CounterBrain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Order
    {
        public List<Product> Products { get; set; }
        public Order()
        {
            Products = new List<Product>();
            CounterBrain = new QuentityMultipierNode();
        }

        public INode CounterBrain { get; set; }
    }
}
