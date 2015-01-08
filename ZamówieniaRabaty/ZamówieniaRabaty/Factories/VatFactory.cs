using ZamówieniaRabaty.Contract;
using ZamówieniaRabaty.Contract.Factories;
using ZamówieniaRabaty.Model.Vats;

namespace ZamówieniaRabaty.Factories
{
    public class VatFactory: IVatFactory
    {
        public IVat GetVat23()
        {
            return new Vat23();
        }
    }
}
