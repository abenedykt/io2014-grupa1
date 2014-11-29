using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    public interface IProduct
    {
        double Weight { get; set; }
        double Price { get; set; }
        string Name { get; set; }
    }

    public interface IDiscount
    {
        Type ProductType { get; set; }
        double discount { get; set; }
    }

    public interface ITax
    {
        Type ProductType { get; set; }
        double tax { get; set; }
    }


    public class Order
    {
        public List<IProduct> _products { get; private set; }

        public Order()
        {
            _products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            _products.Add(product);
        }

        public bool DeleteProduct(IProduct product)
        {
            return true;
        }
    }

        
    public class Delivery 
    {
        private IEnumerable<IProduct> _productList;

        public Delivery(IEnumerable<IProduct> products)
        {
            _productList = products;
        }
        
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    
}
