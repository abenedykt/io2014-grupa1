namespace OrderLibrary
{
    public abstract class ADiscount
    {
        public double Discount { get; set; }
        public ADiscount(double discount)
        {
            Discount = discount;
        }
        abstract public double Calculate(Product product);
    }

    public abstract class ATotalDiscount
    {
        public double Discount { get; set; }
        public double Thresold { get; set; }
        public ATotalDiscount(double discount)
        {
            Discount = discount;
        }

        abstract public double Calculate(double total);
    }

    public class ValueDiscount : ADiscount
    {
        public ValueDiscount(double discount) : base(discount) { }

        override public double Calculate(Product product)
        {
            return Discount;
        }
    }

    public class PercentageDiscount : ADiscount
    {
        public PercentageDiscount(double discount) : base(discount) { }

        override public double Calculate(Product product)
        {
            return product.PriceAfterDiscount * (Discount/100.0);
        }
    }

    public class TotalValueDiscountAboveThresold : ATotalDiscount
    {
        public TotalValueDiscountAboveThresold(double discount, double thresold) : base(discount)
        {
            Thresold = thresold;
        }

        override public double Calculate(double total)
        {
            return total > Thresold ? Discount : 0;
        }
    }
}
