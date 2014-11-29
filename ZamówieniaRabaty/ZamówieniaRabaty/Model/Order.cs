using ZamówieniaRabaty.Contract;
using System.Collections.Generic;

namespace ZamówieniaRabaty.Model
{
    public class Order : IOrder
    {
        public IEnumerable<IItem> Items { get; set; }
        public IEnumerable<IDiscount> Discounts { get; set; }
        public IDelivery Delivery { get; set; }
    }
}
