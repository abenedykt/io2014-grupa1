using System.Collections.Generic;
using ZamówieniaRabaty.Contract;
using ZamówieniaRabaty.Contract.Factories;
using ZamówieniaRabaty.Model;

namespace ZamówieniaRabaty.Factories
{
    public class OrderFactory: IOrderFactory
    {
        public IOrder GetNewOrder()
        {
            IOrder order = new Order(new List<IItem>(), new List<IDiscount>())
            {
                TotalCost = 0,
                TotalCostAfterDiscounts = 0
            };

            return order;
        }
    }
}
