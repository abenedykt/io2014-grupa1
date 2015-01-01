using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    public enum ProductType
    {
        Book,
        ComicBook,
        Wallpaper
    }

    public interface IProduct
    {
        string Name { get; }
        double Cost { get; set; }
        ProductType ProductType { get; }
    }

    public class Product : IProduct
    {
        public string Name
        {
            get;
            private set;
        }

        public double Cost
        {
            get;
            set;
        }

        public ProductType ProductType
        {
            get;
            private set;
        }

        public Product(string name, double cost, ProductType productType)
        {
            Name = name;
            Cost = cost;
            ProductType = productType;
        }
    }
}
