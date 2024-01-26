using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Test
{
    [TestClass]
    public class VendorTests : IDisposable
    {
        public void Dispose()
        {
            Vendor.ClearAll();
        }
        [TestMethod]
        public void VendorConstructor_CreatesInstanceOfConstructor_Vendor()
        {
            Vendor newVendor = new("Suzie's Cafe", "Local coffee shop");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }
    }

}