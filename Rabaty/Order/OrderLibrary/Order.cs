using System.CodeDom;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace OrderLibrary
{
    public class OrderItem
	{
		public Product Product { get; set; }
        public OrderItem(Product product, List<ADiscount> discounts = null)
		{
			Product = product;
		    if (discounts != null)
		        foreach (var item in discounts)
		            Product.PriceAfterDiscount -= item.Calculate(Product);
		}
	}

    public class Order
    {
        private List<OrderItem> _items = new List<OrderItem>();
        private List<ADiscount> _discounts;
        private List<ATotalDiscount> _totalDiscounts;
        public double Total { get; set; }
        public double BaseTotal { get; set; }

        public List<OrderItem> Items
        {
            get {return _items; }
        }
        public Order(List<ADiscount> discounts = null, List<ATotalDiscount> totalDiscounts = null)
        {
            if (discounts != null)
                _discounts = discounts;

            if (totalDiscounts != null)
                _totalDiscounts = totalDiscounts;
        }

        public void Add(OrderItem item)
        {
            _items.Add(item);
        }

        public void Calc()
        {
            foreach (var item in _items)
            {
                if (_discounts != null)
                    foreach (var item2 in _discounts)
                        item.Product.PriceAfterDiscount -= item2.Calculate(item.Product);

                Total += item.Product.PriceAfterDiscount;
            }
            BaseTotal = Total;

            if (_totalDiscounts != null)
                foreach (var item in _totalDiscounts)
                    Total -= item.Calculate(Total);
        }
    }
}
