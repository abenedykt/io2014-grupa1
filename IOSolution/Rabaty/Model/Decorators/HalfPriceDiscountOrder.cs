using Rabaty.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabaty.Model.Decorators
{
    public class HalfPriceDiscountOrder : IOrderDiscountDecorator
    {
        private IOrder _order;
        public List<OrderItem> OrderItems { get; set; }

        public HalfPriceDiscountOrder(IOrder order)
        {
            this._order = order;
            this.OrderItems = this._order.OrderItems;
            this.AddDiscount();
        }

        public void AddItem(Item item, int quantity)
        {
            this.OrderItems.Add(new OrderItem(item, quantity));
        }

        public void AddDiscount()
        {
            this.OrderItems.ForEach(x => x.ItemPrice = x.ItemPrice / 2);
        }
    }
}
