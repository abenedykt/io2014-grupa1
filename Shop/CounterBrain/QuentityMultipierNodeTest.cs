using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shop.CounterBrain
{
    [TestClass]
    public class QuentityMultipierNodeTest
    {
        [TestInitialize]
        public void Init()
        {
            QM = new QuentityMultipierNode();
            Prod = new Product()
            {
                Price = 2
            };
        }
        [TestMethod]
        public void CountProductPrice2Qnty15Should30()
        {
            Assert.AreEqual(30, QM.Count(15, Prod));
        }
        [TestMethod]
        public void NextNodeDefaultShouldBeNull()
        {
            Assert.IsNull(QM.Next);
        }


        public QuentityMultipierNode QM { get; set; }
        public Product Prod { get; set; }
    }
}
//cycl