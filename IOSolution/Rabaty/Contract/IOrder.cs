using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabaty.Contract
{
    public interface IOrder
    {
        double UnitPrice { get; set; }
        int Quantity { get; set; }
        double TaxValue { get; set; }

        double GetPrice();
    }
}
