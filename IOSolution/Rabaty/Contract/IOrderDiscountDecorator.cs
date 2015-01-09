using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabaty.Contract
{
    public interface IOrderDiscountDecorator : IOrder
    {
        void AddDiscount();
    }
}
