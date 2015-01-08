using Rabaty.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabaty
{
    class BaseOrder : AbstractOrder
    {
        public BaseOrder(double initAmount)
        {
            this.TotalAmount = initAmount;
        }

        private double _totalAmount;
        public override double TotalAmount
        {
            get
            {
                return this._totalAmount;
            }
            set
            {
                this._totalAmount = value;
            }
        }
    }
}
