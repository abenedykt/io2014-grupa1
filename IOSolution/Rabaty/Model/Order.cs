using Rabaty.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabaty.Model
{
    class Order : IOrder
    {
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double TaxValue { get; set; }

        public Order(double unitPrice, int quantity, double vat)
        {
            this.UnitPrice = unitPrice;
            this.Quantity = quantity;
            this.TaxValue = vat;
        }

        public double GetPrice()
        {
            var basePrice = this.UnitPrice * this.Quantity;

            return basePrice + basePrice * this.TaxValue;
        }
    }
}
