using ZamówieniaRabaty.Contract;
using System.Collections.Generic;
using System.Linq;

namespace ZamówieniaRabaty.Model
{
    public class Order : IOrder
    {
        public double TotalCost { get; set; }
        public double TotalCostAfterDiscounts { get; set; }

        private List<IItem> items;
        private List<IDiscount> discounts;
        private IDelivery delivery;

        public Order(List<IItem> items, List<IDiscount> discounts)
        {
            this.items = items;
            this.discounts = discounts;
        }

        public void AddItem(IItem item)
        {
            this.items.Add(item);

            this.TotalCost += item.Price;
        }

        public void AddDiscount(IDiscount discount)
        {
            if(this.discounts.Exists(x => x.Combinable == false))
            {
                System.Console.WriteLine("Promocje nie lacza sie ze soba! Nowa promocja nie zostala dodana.");
            }
            else
            {
                this.discounts.Add(discount);
            }
        }

        public void AddDelivery(IDelivery delivery)
        {
            this.delivery = delivery;

            this.TotalCost += delivery.Cost;
            this.TotalCostAfterDiscounts += delivery.Cost;
        }

        public void CalculateTotalCost()
        {
            this.CalculateDiscounts();
            this.CalculateTotalCostAfterDiscounts();
        }

        public double GetTotalCostWithoutDelivery()
        {
            return this.TotalCost - this.delivery.Cost;
        }

        public double GetTotalCostAfterDiscountsWithoutDelivery()
        {
            return this.TotalCostAfterDiscounts - this.delivery.Cost;
        }

        #region Helpers
        private void CalculateDiscounts()
        {
            foreach (var discount in this.discounts)
            {
                discount.Calculate(this.items);
            }
        }

        private void CalculateTotalCostAfterDiscounts()
        {
            foreach (var item in this.items)
            {
                this.TotalCostAfterDiscounts += item.PriceAfterDiscount;
            }
        }
        #endregion
    }
}
