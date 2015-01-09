using Rabaty.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabaty.Model
{
    public class PriceCalculator : IPriceCalculator
    {
        public double CalcOrderPrice(IOrder order)
        {
            return Math.Round(order.OrderItems.Sum(x => x.ItemPrice), 2);
        }
    }
}
