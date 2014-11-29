using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shop
{
    [TestClass]
    public class ProductOrderTest
    {
        public Product Prod { get; set; }
        [TestInitialize]
        public void Init()
        {
            Prod = new Product();
        }
        [TestMethod]
        public void SetNameASD_ShouldNameASD()
        {
            Prod.Name = "ASD";
            Assert.AreEqual("ASD", Prod.Name);
        }
        [TestMethod]
        public void SetPrice12_ShouldPrice12()
        {
            Prod.Price = 12;
            Assert.AreEqual(12, Prod.Price);
        }
    }
}
