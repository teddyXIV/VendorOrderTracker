using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.TestTools
{
    [TestClass]
    public class OrderTests : IDisposable
    {
        public void Dispose()
        {
            Order.ClearAll();
        }
        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            Order newOrder = new("Croissants for Suzie's Cafe", "5 dozen croissants", 100);
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        public void GetTitle_ReturnOrderTitle_String()
        {
            Order newOrder = new("Croissants for Suzie's Cafe", "5 dozen croissants", 100);
            string expected = "Croissants for Suzie's Cafe";
            Assert.AreEqual(expected, newOrder.Title);
        }
    }
}
