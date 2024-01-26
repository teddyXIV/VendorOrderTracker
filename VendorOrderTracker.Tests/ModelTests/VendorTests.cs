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

        [TestMethod]
        public void SetDescription_SetVendorDescription_Void()
        {
            Vendor newVendor = new("Suzie's Cafe", "Local coffee shop");
            newVendor.Description = "Serves coffee and pastries";
            string expected = "Serves coffee and pastries";
            Assert.AreEqual(expected, newVendor.Description);
        }

        [TestMethod]
        public void GetAll_ReturnAllInstancesOfVendors_List()
        {
            Vendor vendor1 = new("Suzie's Cafe", "Local coffee shop");
            Vendor vendor2 = new("Whidbey Coffee", "Regional coffee chain");
            List<Vendor> expected = new() { vendor1, vendor2 };
            CollectionAssert.AreEqual(expected, Vendor.GetAll());
        }

        [TestMethod]
        public void FindVendor_ReturnVendorById_Vendor()
        {
            Vendor vendor1 = new("Suzie's Cafe", "Local coffee shop");
            Vendor vendor2 = new("Whidbey Coffee", "Regional coffee chain");
            Assert.AreEqual(vendor2, Vendor.FindVendor(2));
        }

        [TestMethod]
        public void AddOrder_AddOrderToOrders_Void()
        {
            Vendor newVendor = new("Suzie's Cafe", "Local coffee shop");
            Order newOrder = new("Croissants for Suzie's Cafe", "5 dozen croissants", 100);
            newVendor.AddOrder(newOrder);
            List<Order> expected = new() { newOrder };
            CollectionAssert.AreEqual(expected, newVendor.Orders);
        }
    }

}