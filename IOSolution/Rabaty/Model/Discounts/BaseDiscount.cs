using Rabaty.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabaty.Model.Discounts
{
    class BaseDiscount : IOrderDecorator
    {
        public IOrder Order { get; set; }

        public BaseDiscount(IOrder order)
        {
            this.Order = order;
        }

        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double TaxValue { get; set; }

        public virtual double GetPrice() 
        {
            return this.Order.GetPrice();
        }
    }
}
