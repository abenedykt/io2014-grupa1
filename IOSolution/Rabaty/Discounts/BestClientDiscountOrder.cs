using Rabaty.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabaty.Discounts
{
    class BestClientDiscountOrder : AbstractOrderWithDiscount
    {
        private AbstractOrder _order;
        private double _discount;

        public BestClientDiscountOrder(AbstractOrder order)
        {
            this._order = order;
            if (IsBestClient(order))
            {
                this._discount = 0.25;
            }
            else
            {
                this._discount = 0.0f;
            }
        }

        private bool IsBestClient(AbstractOrder order)
        {
            return order.TotalAmount > 10.00;
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
