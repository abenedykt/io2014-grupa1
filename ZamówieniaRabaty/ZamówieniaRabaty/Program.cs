using System.Collections.Generic;
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
            IOrder order = new Order();

            order.Items = new List<IItem>()
            {
                new FirstProduct() { Description = "Produkt Pierwszy", UnitPrice = 23.90, Vat = new Vat23()}
            };
            order.Discounts = new List<IDiscount>()
            {
                new FirstDiscount() { Name = "Zniżka pierwsza", Percent = 10 }
            };
            order.Delivery = new DPDDelivery() { Cost = 15.00 };
        }
    }
}
