using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.CounterBrain
{
    public interface INode
    {
        int Count(int p, Product Prod);
    }
}
