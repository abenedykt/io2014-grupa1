using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Shop.CounterBrain;
namespace Shop
{
    [TestClass]
    public class OrderTest
    {
        [TestInitialize]
        public void Init()
        {
            Ord = new Order();
        }
        [TestMethod]
        public void AddProduct_ShouldHaveProduct()
        {
            throw new Exception("todo product order");//todo product order
            //var product = new Product();
            //Ord.Products.Add(product);
            //Assert.IsTrue(Ord.Products.Exists(x=>x==product));
        }
        [TestMethod]
        public void ProductsDefaultShouldByEmpty()
        {
            Assert.IsFalse(Ord.Products.Any());
        }
        [TestMethod]
        public void CountChainDefaultShouldInstanceQuentityMultipier()
        {
            Assert.IsInstanceOfType(Ord.CounterBrain, typeof(QuentityMultipierNode));
        }
        [TestMethod]
        public void AddProductPrice15Qnty3ShouldCountEq45()
        {
            throw new Exception("todo product order");//todo product order

            //klocki, zrobic qnty
            //var product = new Product();
            //Ord.Products.Add(product);
            //Assert.IsTrue(Ord.Products.Exists(x=>x==product));
        }

        public Order Ord { get; set; }
    }
}
