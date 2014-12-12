using System.Collections.Generic;

namespace ZamówieniaRabaty.Contract
{
    public interface IOrder
    {
        double TotalCost { get; }
        double TotalCostAfterDiscounts { get; }

        void AddItem(IItem item);
        void AddDiscount(IDiscount discount);
        void AddDelivery(IDelivery delivery);

        void CalculateTotalCost();

        double GetTotalCostWithoutDelivery();
        double GetTotalCostAfterDiscountsWithoutDelivery();
    }
}
