using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabaty.Abstract
{
    public abstract class AbstractOrder
    {
        public abstract double TotalAmount { get; set; }
    }
}
