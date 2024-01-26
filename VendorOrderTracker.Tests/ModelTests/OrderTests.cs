using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.TestTools
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            Order newOrder = new("Croissants for Suzie's Cafe", "5 dozen croissants", 100);
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }
    }
}
