using Rabaty.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabaty.Model.Discounts
{
    class SummerDiscountDecorator : BaseDiscount
    {
        public SummerDiscountDecorator(IOrder order)
            :base(order)
        {

        }

        public override double GetPrice()
        {
            return 0.75 * this.Order.GetPrice();
        }
    }
}
