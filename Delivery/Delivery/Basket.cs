using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    public interface IOrder
    {
        int Quantity { get; set; }
        IProduct Product { get; set; }
    }

    public class Order : IOrder
    {
        public int Quantity { get; set; }
        public IProduct Product { get; set; }
    }

    public interface IBasket
    {
        void AddProduct(IProduct product, int quantity);
        bool RemoveProduct(IProduct product, int quantity);
        IList<IOrder> GetOrders();
    }

    public class Basket : IBasket
    {
        private List<IOrder> _orders;

        public Basket()
        {
            _orders = new List<IOrder>();
        }


        public void AddProduct(IProduct product, int quantity)
        {
            if (_orders.Any(x => x.Product.Name == product.Name))
            {
                _orders.SingleOrDefault(x => x.Product.Name == product.Name).Quantity += quantity;
                return;
            }
            _orders.Add(new Order { Product = product, Quantity = quantity });
        }

        public bool RemoveProduct(IProduct product, int quantity)
        {
            if (_orders.Any(x => x.Product.Name == product.Name))
            {
                var delOrder = _orders.SingleOrDefault(x => x.Product.Name == product.Name);
                _orders.Remove(delOrder);
                return true;
            }
            return false;
        }

        public IList<IOrder> GetOrders()
        {
            return _orders;
        }
    }
}
