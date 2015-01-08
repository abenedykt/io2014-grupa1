using Rabaty.Abstract;
using Rabaty.Discounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabaty.Factory
{
    public enum OrderType
    {
        Christmas,
        Holiday,
        BestClient
    }

    public class DiscountFactory
    {
        public static AbstractOrder GetOrderWithDiscount(AbstractOrder baseOrder, OrderType type)
        {
            switch (type)
            {
                case OrderType.Christmas:
                    return GetChristmasDiscountOrder(baseOrder);
                case OrderType.Holiday:
                    return GetHolidayDiscountOrder(baseOrder);
                case OrderType.BestClient:
                    return GetBestClientDiscountOrder(baseOrder);
                default:
                    return baseOrder;
            }
        }

        private static AbstractOrder GetBestClientDiscountOrder(AbstractOrder baseOrder)
        {
            return new BestClientDiscountOrder(baseOrder);
        }

        private static AbstractOrder GetHolidayDiscountOrder(AbstractOrder baseOrder)
        {
            var halfPriceOrder = new HalfPriceDiscountOrder(baseOrder);

            return new FivePercentDiscountOrder(halfPriceOrder);
        }

        private static AbstractOrder GetChristmasDiscountOrder(AbstractOrder baseOrder)
        {
            var twoPercentOrder = new TwoPercentDiscountOrder(baseOrder);
            var fivePercentOrder = new FivePercentDiscountOrder(twoPercentOrder);

            return new BestClientDiscountOrder(fivePercentOrder);
        }
    }
}
