namespace ZamówieniaRabaty.Contract
{
    public interface IDiscount
    {
        string Name { get; set; }
        int Percent { get; set; }
    }
}
