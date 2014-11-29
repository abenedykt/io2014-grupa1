using System.Collections.Generic;

namespace ZamówieniaRabaty.Contract
{
    public interface IOrder
    {
        IEnumerable<IItem> Items { get; set; }
        IEnumerable<IDiscount> Discounts { get; set; }
        IDelivery Delivery { get; set; }
    }
}
