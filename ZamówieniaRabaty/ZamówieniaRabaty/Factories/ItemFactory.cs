using ZamówieniaRabaty.Contract;
using ZamówieniaRabaty.Contract.Factories;
using ZamówieniaRabaty.Model.Items;

namespace ZamówieniaRabaty.Factories
{
    public class ItemFactory: IItemFactory
    {
        private IVatFactory vatFactory;

        public ItemFactory(IVatFactory vatFactory)
        {
            this.vatFactory = vatFactory;
        }

        public IItem GetMouseItem()
        {
            IItem item = new Mouse()
            {
                Name = "Myszka",
                Price = 12.00,
                PriceAfterDiscount = 12.00,
                Vat = this.vatFactory.GetVat23()
            };

            return item;
        }

        public IItem GetKeyboardItem()
        {
            IItem item = new Keyboard()
            {
                Name = "Klawiatura",
                Price = 19.00,
                PriceAfterDiscount = 19.00,
                Vat = this.vatFactory.GetVat23()
            };

            return item;
        }
    }
}
