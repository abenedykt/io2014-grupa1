using System;
namespace Rabaty.Contract
{
    public interface IPriceCalculator
    {
        double CalcOrderPrice(IOrder order);
    }
}
