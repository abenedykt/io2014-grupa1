using Rabaty.Contract;
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
            IOrder order = OrderFactory.GetEmptyOrder();
            IItemRepository repository = ItemRepositoryFactory.GetItemRepository();

            order.AddItem(repository.GetItemById("00001"), 4);
            order.AddItem(repository.GetItemById("00003"), 1);
            order.AddItem(repository.GetItemById("00005"), 3);
            order.AddItem(repository.GetItemById("00002"), 1);
            order.AddItem(repository.GetItemById("00002"), 1);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
