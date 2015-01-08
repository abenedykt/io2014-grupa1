namespace ZamówieniaRabaty.Contract.Factories
{
    public interface IDiscountFactory
    {
        IDiscount GetDiscountMinusTwentyPercent();
        IDiscount GetDiscountSecondItemFree();
    }
}
