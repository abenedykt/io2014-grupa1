using ZamówieniaRabaty.Contract;

namespace ZamówieniaRabaty.Model.Items
{
    public class FirstProduct : IItem
    {
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public IVat Vat { get; set; }
    }
}
