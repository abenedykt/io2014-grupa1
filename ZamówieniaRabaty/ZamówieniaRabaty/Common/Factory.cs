using System.Collections.Generic;
using ZamówieniaRabaty.Contract;
using ZamówieniaRabaty.Model;
using ZamówieniaRabaty.Model.Deliveries;
using ZamówieniaRabaty.Model.Discounts;
using ZamówieniaRabaty.Model.Items;
using ZamówieniaRabaty.Model.Vats;

namespace ZamówieniaRabaty.Common
{
    public class Factory
    {
        public IOrder GetNewOrder()
        {
            IOrder order = new Order(new List<IItem>(), new List<IDiscount>())
            {
                TotalCost = 0,
                TotalCostAfterDiscounts = 0
            };

            return order;
        }
        
        #region Deliveries
        public IDelivery GetDPDDelivery()
        {
            IDelivery delivery = new DPDDelivery()
            {
                Cost = 15.00
            };

            return delivery;
        }
        #endregion

        #region Vats
        public IVat GetVat23()
        {
            return new Vat23();
        }
        #endregion

        #region Discounts
        public IDiscount GetDiscountMinusTwentyPercent()
        {
            IDiscount discount = new DiscountMinusTwentyPercent()
            {
                Name = "Promocja minus 20%"
            };

            return discount;
        }

        public IDiscount GetDiscountSecondItemFree()
        {
            IDiscount discount = new SecondItemFree()
            {
                Name = "Promocja druga, tańsza rzecz gratis"
            };

            return discount;
        }
        #endregion

        #region Items
        public IItem GetMouseItem()
        {
            IItem item = new Mouse()
            {
                Name = "Myszka",
                Price = 12.00,
                PriceAfterDiscount = 12.00,
                Vat = this.GetVat23()
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
                Vat = this.GetVat23()
            };

            return item;
        }
        #endregion
    }
}
