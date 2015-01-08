using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabaty.Abstract
{
    abstract class AbstractOrderWithDiscount : AbstractOrder
    {
        public abstract double Discount { get; }
    }
}
