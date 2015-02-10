using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklepik
{
    public class Produkt
    {

        public string Name { get; set; }
        public double Price { get; set; }
        public double Netto { get; set; }
        public double Vat { get; set; }
        public Produkt (string name, double netto, double vat = 0.23)
        {

            Name = name;
            Netto = netto;
            Vat = vat;
        }
        public abstract class Discount
        {
            public double discount { get; set; }
            public Discount(double discount)
            {
                this.discount = discount;
            }

            abstract public double Policz(Produkt produkt);
        }
      
    }


    public class OrderItem
    {
        protected Produkt product { get; set; }
        public OrderItem(Produkt product, Produkt.Discount[] discounts = null)
        {
            this.product = product;
            if (discounts != null)
            {
                foreach (Produkt.Discount discount in discounts)
                {
                    this.product.Netto -= discount.Policz(this.product);
                }
            }
        }
    }
    public class Order
	{
       
        
		List<OrderItem> items = new List<OrderItem> ();
		
       
      
        public void Add(OrderItem item)
        {
            this.items.Add(item);
        }
     

      

        public Order()
        {
            // TODO: Complete member initialization
        }







        
    }
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Produkt>
            {
                new Produkt("linijka", 2),
                new Produkt("ołowek", 13),
                new Produkt("pilka", 69)

            };
            Order order = new Order();
            order.Add(new OrderItem(products[1]));
            order.Add(new OrderItem(products[2]));
            order.Add(new OrderItem(products[3]));
         
            Console.WriteLine (order);

        }
    }
}
