using System;

namespace Shop.CounterBrain
{
    public class QuentityMultipierNode : INode
    {
        public int Count(int p, Product Prod)
        {
            return p * Prod.Price;
        }
        public INode Next { get; set; }
    }
}
