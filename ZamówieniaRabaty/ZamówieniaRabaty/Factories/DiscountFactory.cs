using ZamówieniaRabaty.Contract;
using ZamówieniaRabaty.Contract.Factories;
using ZamówieniaRabaty.Model.Discounts;

namespace ZamówieniaRabaty.Factories
{
    public class DiscountFactory: IDiscountFactory
    {
        public IDiscount GetDiscountMinusTwentyPercent()
        {
            IDiscount discount = new DiscountMinusTwentyPercent()
            {
                Name = "Promocja minus 20%",
                Combinable = false
            };

            return discount;
        }

        public IDiscount GetDiscountSecondItemFree()
        {
            IDiscount discount = new SecondItemFree()
            {
                Name = "Promocja druga, tańsza rzecz gratis",
                Combinable = false
            };

            return discount;
        }
    }
}
