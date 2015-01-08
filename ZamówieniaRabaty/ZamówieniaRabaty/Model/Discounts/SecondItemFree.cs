using System.Collections.Generic;
using System.Linq;
using ZamówieniaRabaty.Contract;

namespace ZamówieniaRabaty.Model.Discounts
{
    public class SecondItemFree: IDiscount
    {
        public string Name { get; set; }

        public void Calculate(IEnumerable<IItem> items)
        {
            items.OrderBy(x => x.Price).First().PriceAfterDiscount = 0;
        }
    }
}
