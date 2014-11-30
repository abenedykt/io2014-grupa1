using System;
using System.Collections.Generic;

namespace Orders
{
	public class ProductDetailsItem
	{
		public string symbol { get; set; }
		public string name { get; set; }
		public object details { get; set; } //tutaj sobie można Linqiem pogmerać przy zniżkach

		public ProductDetailsItem(string symbol, string name, object details)
		{
			this.symbol = symbol;
			this.name = name;
			this.details = details;
		}

		override public string ToString()
		{
			return this.name + ": " + this.details.ToString () + "\n";
		}
	}

	public class Product
	{
		private double _vat;
		private double _netto_price;
		public string name { get; set; }
		public double netto_price {
			get {
				return this._netto_price;
			}
			set {
				this._netto_price = value < 0 ? 0 : value;
				this.vat = this.vat;//trigger price calculation
			}
		}
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
		public List<ProductDetailsItem> product_details = new List<ProductDetailsItem>();
		public double base_price { get; set; }

		public Product(string name, double netto_price, double vat = 0.08, List<ProductDetailsItem> product_details = null)
		{
			this.name = name;
			this.netto_price = netto_price;
			this.vat = vat;
			this.product_details = product_details;
			this.base_price = netto_price;
		}

		override public string ToString()
		{
			return String.Format("{0}\n\t{1:c} brutto w tym {2:p} VAT", this.name, this.price, this.vat);
		}
	}

	public abstract class ADiscount
	{
		public double discount { get; set; }
		public ADiscount(double discount)
		{
			this.discount = discount;
		}

		abstract public double Calculate (Product product);
	}

	public abstract class ATotalDiscount
	{
		public double discount { get; set; }
		public double thresold { get; set; }
		public ATotalDiscount(double discount)
		{
			this.discount = discount;
		}

		abstract public double Calculate (double total);
	}

	public class TotalFixedDiscountForAboveThresold : ATotalDiscount
	{
		public TotalFixedDiscountForAboveThresold(double discount, double thresold) : base(discount)
		{
			this.thresold = thresold;
		}

		override public double Calculate(double total)
		{
			if(total > this.thresold)
				return this.discount;

			return 0;
		}
	}

	public class FixedDiscount : ADiscount
	{
		public FixedDiscount(double discount) : base(discount) { }

		override public double Calculate(Product product)
		{
			return this.discount;
		}
	}

	public class PercentageDiscount : ADiscount
	{
		public PercentageDiscount(double discount) : base(discount) { }

		override public double Calculate(Product product)
		{
			return product.netto_price * this.discount;
		}
	}

	public class ClothesPercentageDiscount : ADiscount
	{
		public ClothesPercentageDiscount(double discount) : base(discount) { }

		override public double Calculate(Product product)
		{
			if (product.product_details != null)
			{
				foreach(var details in product.product_details)
				{
					if (details.symbol == "category" && (string)details.details == "clothes")
						return product.netto_price * this.discount;
				}
			}

			return 0;
		}
	}

	public class QuantityUnder10FixedDiscount : ADiscount
	{
		public QuantityUnder10FixedDiscount(double discount) : base(discount) { }

		override public double Calculate(Product product)
		{
			if (product.product_details != null)
			{
				foreach(var details in product.product_details)
				{
					if (details.symbol == "quantity" && (int)details.details < 10)
						return this.discount;
				}
			}

			return 0;
		}
	}

	public class YamahaManufacturerPercentageDiscount : ADiscount
	{
		public YamahaManufacturerPercentageDiscount(double discount) : base(discount) { }

		override public double Calculate(Product product)
		{
			if (product.product_details != null)
			{
				foreach(var details in product.product_details)
				{
					if (details.symbol == "manufacturer" && (string)details.details == "Yamaha")
						return product.netto_price * this.discount;
				}
			}

			return 0;
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
					this.product.netto_price -= discount.Calculate(this.product);
				}
			}
		}
	}

	public class Order
	{
		List<OrderItem> items = new List<OrderItem> ();
		ADiscount[] discounts;
		ATotalDiscount[] total_discounts;
		public double total { get; set; }
		public double base_total { get; set; }

		public Order(ADiscount[] discounts = null, ATotalDiscount[] total_discounts = null)
		{
			if (discounts != null)
				this.discounts = discounts;

			if (total_discounts != null)
				this.total_discounts = total_discounts;
		}

		public void Add(OrderItem item)
		{
			this.items.Add (item);
		}

		public void Calc()
		{
			foreach (var item in this.items)
			{
				if (this.discounts != null)
				{
					foreach (var discount in this.discounts)
						item.product.netto_price -= discount.Calculate (item.product);
				}
				this.total += item.product.price;
			}
			this.base_total = this.total;

			if (this.total_discounts != null)
			{
				foreach (var discount in this.total_discounts)
					this.total -= discount.Calculate (this.total);
			}
		}

		override public string ToString()
		{
			string tmp = "Produkty w zamówieniu\n";
			int i = 1;
			foreach(var item in items)
			{
				tmp += String.Format("#{0}\t", i++);
				tmp += item.product + "\n";
				tmp += String.Format("\t{0:c} netto", item.product.netto_price);
				if (item.product.netto_price != item.product.base_price)
				{
					tmp += String.Format("; {0:c} netto zniżki", item.product.base_price - item.product.netto_price);
					tmp += String.Format("; cena podstawowa {0:c} netto", item.product.base_price);
				}
				tmp += "\n";
				if (item.product.product_details != null)
				{
					foreach (var details in item.product.product_details)
					{
						tmp += "\t" + details.ToString ();	
					}
				}
				tmp += "\n";
			}
			tmp += String.Format("Do zapłaty: {0:c}\n", this.total);

			if(this.total < this.base_total)
				tmp += String.Format("Przed rabatem całości zamówienia: {0:c}; rabat {1:c}\n", this.base_total, this.base_total - this.total);

			return tmp;
		}
	}

	public class MainClass
	{
		static public void Main ()
		{
			//lista produktów
			var products = new List<Product> ();

			//produkt: domyślny vat 8%, brak listy szczegółów
			products.Add (new Product ("Dysk twardy", 100));

			//kategoria ubrania (element listy szczegółów)
			var clothes_category = new ProductDetailsItem ("category", "Kategoria", "clothes");

			//lista szczegółów dla przedmiotu koszula
			List<ProductDetailsItem> shirt_details = new List<ProductDetailsItem> ();
			//przypisanie kategorii ect
			shirt_details.Add (clothes_category);
			shirt_details.Add (new ProductDetailsItem ("size", "Rozmiar", "Medium"));
			shirt_details.Add (new ProductDetailsItem ("quantity", "Ilość", 74));
			//dopisanie produktu do listy. nazwa, cena, vat, szczegóły
			products.Add (new Product ("Koszula długi rękaw", 100, 0.23, shirt_details));

			List<ProductDetailsItem> hat_details = new List<ProductDetailsItem> ();
			hat_details.Add (clothes_category);
			hat_details.Add (new ProductDetailsItem ("size", "Rozmiar", "Extra large"));
			hat_details.Add (new ProductDetailsItem ("quantity", "Ilość", 4));
			products.Add (new Product ("Czapka uszatka", 69, 0.08, hat_details));

			List<ProductDetailsItem> guitar_details = new List<ProductDetailsItem> ();
			guitar_details.Add (new ProductDetailsItem ("type", "Typ", "acoustic"));
			guitar_details.Add (new ProductDetailsItem ("cutway", "Cutway", true));
			guitar_details.Add (new ProductDetailsItem ("manufacturer", "Producent", "Yamaha"));
			guitar_details.Add (new ProductDetailsItem ("quantity", "Ilość", 2));
			products.Add (new Product ("Gitara", 1200, 0.08, guitar_details));

			//obiekt zamówienia z konstruktowem zawierającym tablice ze zniżkami globalnymi (sparametryzowanymi)
			var order = new Order (new ADiscount[] { new FixedDiscount(20), new ClothesPercentageDiscount(0.01), new QuantityUnder10FixedDiscount(5), new YamahaManufacturerPercentageDiscount(0.1) }, new ATotalDiscount[] { new TotalFixedDiscountForAboveThresold(100, 1100) });
			//dodawanie produktów, mogą zawierać tablice zniżek
			order.Add (new OrderItem (products[0], new ADiscount[] { new PercentageDiscount(0.05), new FixedDiscount(10) }));
			order.Add (new OrderItem (products[1]));
			order.Add (new OrderItem (products[2]));
			order.Add (new OrderItem (products[3]));
			//obliczanie wartość zamówienia
			order.Calc ();
			//print na ekran (z uwzglednieniem zniżek. BTW zniżki ustalane są dla cen netto)
			Console.WriteLine (order);
		}
	}
}