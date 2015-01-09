using Rabaty.Contract;
using Rabaty.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabaty.Factory
{
    public class OrderFactory
    {
        public static IOrder GetEmptyOrder()
        {
            return new BaseOrder();
        }
    }
}
