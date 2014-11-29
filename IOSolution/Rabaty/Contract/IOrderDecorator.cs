using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabaty.Contract
{
    interface IOrderDecorator : IOrder
    {
        IOrder Order { get; set; }
    }
}
