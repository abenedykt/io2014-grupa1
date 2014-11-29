using Rabaty.Contract;
using Rabaty.Model;
using Rabaty.Model.Discounts;
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
            var order = new Order(29.99, 3, 23);

            var orderSummerSale = new SummerDiscountDecorator(order);
            var orderBlackFriday = new BlackFridayDiscountDecorator(orderSummerSale);

            ShowPriceOnConsole(orderBlackFriday);

            Console.ReadKey();
        }

        static void ShowPriceOnConsole(IOrder order)
        {
            Console.WriteLine(order.GetPrice());
        }
    }
}
