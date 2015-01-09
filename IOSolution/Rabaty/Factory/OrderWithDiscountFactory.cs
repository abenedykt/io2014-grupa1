using Rabaty.Contract;
using Rabaty.Model.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabaty.Factory
{
    public class OrderWithDiscountFactory
    {
        public static IOrder GetFirstItemFreeOrderDisc(IOrder order)
        {
            return new FirstItemFreeDiscountOrder(order);
        }

        public static IOrder GetHalfPriceOrderDisc(IOrder order)
        {
            return new HalfPriceDiscountOrder(order);
        }
    }
}
