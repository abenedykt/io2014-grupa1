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
			return this.discount;
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
		public Product product { get; set; }
		public OrderItem(Product product, ADiscount[] discounts = null)
		{
			this.product = product;
			if (discounts != null)
			{
				foreach (ADiscount discount in discounts)
				{
					this.product.netto_price -= discount.Calculate(this.product.netto_price);
				}
			}
		}
	}

	public class Order
	{
		List<OrderItem> items = new List<OrderItem> ();
		List<ADiscount> discounts = new List<ADiscount> ();
		public double total { get; set; }

		public Order(ADiscount[] discounts = null)
		{
			if (discounts != null)
			{
				foreach(ADiscount discount in discounts)
				{
					this.discounts.Add (discount);
				}
			}
		}

		public void Add(OrderItem item)
		{
			this.items.Add (item);
		}

		public void CalculateTotal()
		{
			foreach (var item in this.items)
			{
				this.total += item.product.netto_price;
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

			var order = new Order ();
			order.Add (new OrderItem (products[0], new ADiscount[] { new PercentageDiscount(0.05), new FixedDiscount(10) }));
			order.CalculateTotal();
			Console.WriteLine (order.total);
			//orderotem(produkt, *rabat)
			//order(orderitems, *rabat)
		}
	}
}