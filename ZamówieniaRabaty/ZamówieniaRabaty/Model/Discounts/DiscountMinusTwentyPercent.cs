using System.Collections.Generic;
using ZamówieniaRabaty.Contract;

namespace ZamówieniaRabaty.Model.Discounts
{
    public class DiscountMinusTwentyPercent : IDiscount
    {
        public string Name { get; set; }
        public bool Combinable { get; set; }

        public void Calculate(IEnumerable<IItem> items)
        {
            foreach (var item in items)
            {
                item.PriceAfterDiscount = item.Price - item.Price * 0.2;
            }
        }
    }
}
