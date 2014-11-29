using System.Collections.Generic;

namespace Orders
{
    public class Order
    {
        public List<ProductInOrder> Products { get; set; }
        public double DeliveryCost { get; set; }

    }

    public class ProductInOrder
    {
        public Product Producta { get; set; }
        public double Tax { get; set; }
        public double Discount { get; set; }

        public double EndPrice()
        {
            return (Producta.Price + (Producta.Price*Tax/100.0))*(Discount/100.0);
        }
    }
    public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }
    }
    //zrobic klase rabat
}
