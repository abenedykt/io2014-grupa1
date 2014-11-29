namespace ZamówieniaRabaty.Contract
{
    public interface IItem
    {
        string Description { get; set; }
        double UnitPrice { get; set; }

        IVat Vat { get; set; }
    }
}
