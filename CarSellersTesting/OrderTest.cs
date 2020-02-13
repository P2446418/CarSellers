using System;
using CarSellersClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarSellersTesting
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void InstanceOK() { 
            clsOrder anOrder = new clsOrder();
            Assert.IsNotNull(anOrder);
        }
    }
}
