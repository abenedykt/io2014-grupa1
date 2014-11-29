using System;
using System.Collections.Generic;

namespace Orders
{
	public class Product
	{
		private double _vat;
		public string name { get; set; }
		public double netto_price { get; set; }
		public double price { get; set; }
		public double vat {
			get {
				return this._vat;
			}
			set {
				this._vat = value;
				this.price = this.netto_price * (1 + this.vat); 
			}
		}

		public Product(string name, double netto_price, double vat = 8)
		{
			this.name = name;
			this.netto_price = netto_price;
			this.vat = vat;
		}

		override public string ToString()
		{
			return "Name: " + this.name + "; Price: " + this.price + "; VAT: " + this.vat;
		}
	}

	public abstract class ADiscount
	{
		public double discount { get; set; }

		abstract public double Calculate (double price);
	}

	public class FixedDiscount : ADiscount
	{
		public FixedDiscount(double discount)
		{
			this.discount = discount;
		}

		override public double Calculate(double price)
		{
			return price;
		}
	}

	public class PercentageDiscount : ADiscount
	{
		public PercentageDiscount(double discount)
		{
			this.discount = discount;
		}

		override public double Calculate(double price)
		{
			return price * this.discount;
		}
	}

	public class OrderItem
	{
		public OrderItem(Product product, ADiscount[] discounts = null)
		{
			if (discounts != null)
			{
				foreach (ADiscount discount in discounts)
				{
					Console.WriteLine (product.netto_price);
					product.netto_price -= discount.Calculate(product.netto_price);
					Console.WriteLine (product.netto_price);
					Console.WriteLine ();
				}
			}
		}


	}

	public class MainClass
	{
		static public void Main ()
		{
			var products = new List<Product> ();
			products.Add (new Product ("test", 100, 0.23));
			products.Add (new Product ("test2", 40, 0.8));
			products.Add (new Product ("test3", 29.95, 0.8));

			var oi = new OrderItem (products[1], new ADiscount[] { new PercentageDiscount(0.05), new FixedDiscount(10) });

			//var order = new Order ();
			//order.AddItem (new OrderItem(products[1]));

			//orderotem(produkt, *rabat)
			//order(orderitems, *rabat)
		}
	}
}