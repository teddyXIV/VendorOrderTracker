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

        [TestMethod]
        public void GetName_ReturnVendorName_String()
        {
            Vendor newVendor = new("Suzie's Cafe", "Local coffee shop");
            string expected = "Suzie's Cafe";
            Assert.AreEqual(expected, newVendor.Name);
        }

        [TestMethod]
        public void SetName_SetVendorName_Void()
        {
            Vendor newVendor = new("Suzie's Cafe", "Local coffee shop");
            newVendor.Name = "SC";
            string expected = "SC";
            Assert.AreEqual(expected, newVendor.Name);
        }

        [TestMethod]
        public void GetDescription_ReturnVendorDescription_String()
        {
            Vendor newVendor = new("Suzie's Cafe", "Local coffee shop");
            string expected = "Local coffee shop";
            Assert.AreEqual(expected, newVendor.Description);
        }
    }

}