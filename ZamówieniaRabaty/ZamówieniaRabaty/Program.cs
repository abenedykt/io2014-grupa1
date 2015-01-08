using System;
using ZamówieniaRabaty.Contract;
using ZamówieniaRabaty.Contract.Factories;
using ZamówieniaRabaty.Factories;

namespace ZamówieniaRabaty
{
    class Program
    {
        static void Main(string[] args)
        {
            IOrderFactory orderFactory = new OrderFactory();
            IDeliveryFactory deliveryFactory = new DeliveryFactory();
            IDiscountFactory discountFactory = new DiscountFactory();
            IVatFactory vatFactory = new VatFactory();
            IItemFactory itemFactory = new ItemFactory(vatFactory);

            //-----------------

            IOrder order = orderFactory.GetNewOrder();

            order.AddItem(itemFactory.GetMouseItem());
            order.AddItem(itemFactory.GetKeyboardItem());

            order.AddDelivery(deliveryFactory.GetDPDDelivery());

            order.AddDiscount(discountFactory.GetDiscountMinusTwentyPercent());
            order.AddDiscount(discountFactory.GetDiscountSecondItemFree());

            order.CalculateTotalCost();

            Console.WriteLine("koszt bez wysylki " + order.GetTotalCostWithoutDelivery());
            Console.WriteLine("koszt z wysylka: " + order.TotalCost);
            
            Console.WriteLine("koszt uwzgledniajacy znizki bez wysylki " + order.GetTotalCostAfterDiscountsWithoutDelivery());
            Console.WriteLine("koszt uwzgledniajacy znizki " + order.TotalCostAfterDiscounts);
        }
    }
}
