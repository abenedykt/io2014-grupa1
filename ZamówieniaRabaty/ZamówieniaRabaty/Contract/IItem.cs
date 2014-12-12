namespace ZamówieniaRabaty.Contract
{
    public interface IItem
    {
        string Name { get; set; }
        double Price { get; set; }
        double PriceAfterDiscount { get; set; }

        IVat Vat { get; set; }
    }
}
