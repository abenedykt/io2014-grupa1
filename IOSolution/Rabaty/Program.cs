using Rabaty.Abstract;
using Rabaty.Discounts;
using Rabaty.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabaty
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractOrder order = new BaseOrder(19.99f);

            order = DiscountFactory.GetOrderWithDiscount(order, OrderType.BestClient);

            Console.WriteLine(order.TotalAmount);

            Console.ReadKey();
        }
    }
}
