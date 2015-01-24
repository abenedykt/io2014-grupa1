using Rabaty.Contract;
using Rabaty.Factory;
using Rabaty.Model;
using Rabaty.Model.Decorators;
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
            IOrder order = OrderFactory.GetEmptyOrder();
            IItemRepository repository = ItemRepositoryFactory.GetItemRepository();
            IPriceCalculator calculator = PriceCalculatorFactory.GetPriceCalculator();

            order.AddItem(repository.GetItemById("00001"), 4);
            order.AddItem(repository.GetItemById("00003"), 1);
            order.AddItem(repository.GetItemById("00005"), 3);
            order.AddItem(repository.GetItemById("00002"), 1);
            order.AddItem(repository.GetItemById("00002"), 1);

            order = OrderWithDiscountFactory.GetFirstItemFreeOrderDisc(order);
            order = OrderWithDiscountFactory.GetHalfPriceOrderDisc(order);
            
            double total = calculator.CalcOrderPrice(order);

            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}
