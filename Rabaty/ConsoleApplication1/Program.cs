using System;
using Orders;

namespace ConsoleApplication1
{
    class Program
    {
        private static void Main()
        {
            var p1 = new Product("produkt 1", 121.21);
            var p2 = new Product("produkt 2", 234.21);
            var p3 = new Product("produkt 3", 21.21);
            var order = new Order {DeliveryCost = 50.12};
            order.Products.Add(new ProductInOrder() {Discount = 25,Producta = p1, Tax = 23});
            order.Products.Add(new ProductInOrder() { Discount = 10, Producta = p2, Tax = 8 });
            order.Products.Add(new ProductInOrder() { Discount = 15, Producta = p3, Tax = 22 });

            foreach (var item in order.Products)
            {
                Console.WriteLine(item.Producta.Name + "\t" + item.Producta.Price + "\t" + item.Tax + "\t" + item.EndPrice());
            }
        }

        
        
    }
}
