using System;
using System.Collections.Generic;
using ZamówieniaRabaty.Common;
using ZamówieniaRabaty.Contract;
using ZamówieniaRabaty.Model;
using ZamówieniaRabaty.Model.Deliveries;
using ZamówieniaRabaty.Model.Discounts;
using ZamówieniaRabaty.Model.Items;
using ZamówieniaRabaty.Model.Vats;

namespace ZamówieniaRabaty
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();

            IOrder order = factory.GetNewOrder();
            order.AddItem(factory.GetMouseItem());
            order.AddItem(factory.GetKeyboardItem());
                
            order.AddDelivery(factory.GetDPDDelivery());

            order.AddDiscount(factory.GetDiscountSecondItemFree());

            order.CalculateTotalCost();

            Console.WriteLine("koszt " + order.TotalCost);
            Console.WriteLine("koszt ostateczny " + order.TotalCostAfterDiscounts);

            Console.WriteLine("koszt bez wysylki " + order.GetTotalCostWithoutDelivery());
            Console.WriteLine("koszt ostateczny bez wysylki " + order.GetTotalCostAfterDiscountsWithoutDelivery());
        }
    }
}
