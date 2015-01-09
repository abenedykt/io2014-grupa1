using Rabaty.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabaty.Contract
{
    public interface IOrder
    {
        List<OrderItem> OrderItems { get; set; }

        void AddItem(Item item, int quantity);
    }
}
