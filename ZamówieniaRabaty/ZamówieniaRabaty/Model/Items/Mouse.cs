using ZamówieniaRabaty.Contract;

namespace ZamówieniaRabaty.Model.Items
{
    public class Mouse : IItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double PriceAfterDiscount { get; set; }

        public IVat Vat { get; set; }
    }
}
