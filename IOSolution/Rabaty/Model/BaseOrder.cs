using Rabaty.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabaty.Model
{
    class BaseOrder : IOrder
    {
        public List<OrderItem> OrderItems { get; set; }

        public BaseOrder()
        {
            this.OrderItems = new List<OrderItem>();
        }

        public void AddItem(Item item, int quantity = 1)
        {
            this.OrderItems.Add(new OrderItem(item, quantity));
        }
    }
}
