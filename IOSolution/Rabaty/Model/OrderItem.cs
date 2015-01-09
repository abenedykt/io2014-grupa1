using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabaty.Model
{
    public class OrderItem
    {
        public Item Item { get; set; }
        public int Quantity { get; set; }

        public OrderItem(Item item, int quantity)
        {
            this.Item = item;
            this.Quantity = quantity;
        }

        public double ItemPrice
        {
            get
            {
                return (this.Item.UnitPrice  + (this.Item.UnitPrice * this.Item.Vat)) * this.Quantity;
            }
        }
    }
}
