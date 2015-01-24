using System;
using System.Collections.Generic;
using OrderLibrary;

namespace Order
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product("Item1", 100),
                new Product("Item2", 70),
                new Product("Item3", 69)
            };


            var discountList = new List<ADiscount> {new ValueDiscount(15), new PercentageDiscount(30)};
            var totalDiscountList = new List<ATotalDiscount> {new TotalValueDiscountAboveThresold(70, 100)};

            var order = new OrderLibrary.Order(discountList, totalDiscountList);

            order.Add(new OrderItem(products[0]));
            order.Add(new OrderItem(products[1]));
            order.Add(new OrderItem(products[2]));

            order.Calc();

            foreach (var item in order.Items)
            {
                Console.WriteLine("{0}, netto: {1}, after discount: {2}", item.Product.Name, item.Product.Netto, item.Product.PriceAfterDiscount);
            }

			

			Console.WriteLine (order.Total);
		}
    }
}
