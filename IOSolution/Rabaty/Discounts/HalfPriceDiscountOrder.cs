using Rabaty.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabaty.Discounts
{
    class HalfPriceDiscountOrder : AbstractOrderWithDiscount
    {
        private AbstractOrder _order;
        private double _discount;

        public HalfPriceDiscountOrder(AbstractOrder order)
        {
            this._order = order;
            this._discount = 0.5;
        }

        public override double Discount
        {
            get
            {
                return this._discount;
            }
        }

        public override double TotalAmount
        {
            get
            {
                return this._order.TotalAmount - (this._order.TotalAmount * this.Discount);
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
