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

        [TestMethod]
        public void SetTitle_SetsOrderTitle_Void()
        {
            Order newOrder = new("Croissants for Suzie's Cafe", "5 dozen croissants", 100);
            newOrder.Title = "Suzie's order";
            string expected = "Suzie's order";
            Assert.AreEqual(expected, newOrder.Title);
        }

        [TestMethod]
        public void GetDescription_ReturnOrderDescription_String()
        {
            Order newOrder = new("Croissants for Suzie's Cafe", "5 dozen croissants", 100);
            string expected = "5 dozen croissants";
            Assert.AreEqual(expected, newOrder.Description);
        }

        [TestMethod]
        public void SetDescription_SetsOrderDescription_Void()
        {
            Order newOrder = new("Croissants for Suzie's Cafe", "5 dozen croissants", 100);
            newOrder.Description = "60 croissants";
            string expected = "60 croissants";
            Assert.AreEqual(expected, newOrder.Description);
        }

        [TestMethod]
        public void GetPrice_ReturnOrderPrice_Int()
        {
            Order newOrder = new("Croissants for Suzie's Cafe", "5 dozen croissants", 100);
            int expected = 100;
            Assert.AreEqual(expected, newOrder.Price);
        }

        [TestMethod]
        public void SetPrice_SetsOrderPrice_Void()
        {
            Order newOrder = new("Croissants for Suzie's Cafe", "5 dozen croissants", 100);
            newOrder.Price = 80;
            int expected = 80;
            Assert.AreEqual(expected, newOrder.Price);
        }

        [TestMethod]
        public void GetDate_ReturnOrderDate_String()
        {
            Order newOrder = new("Croissants for Suzie's Cafe", "5 dozen croissants", 100);
            string expected = "1/26/2024";
            Assert.AreEqual(expected, newOrder.Date);
        }
        [TestMethod]
        public void GetId_ReturnOrderId_Int()
        {
            Order newOrder = new("Croissants for Suzie's Cafe", "5 dozen croissants", 100);
            int expected = 1;
            Assert.AreEqual(expected, newOrder.Id);
        }
        [TestMethod]
        public void FindOrder_ReturnOrderById_Order()
        {
            Order order1 = new("Croissants for Suzie's Cafe", "5 dozen croissants", 100);
            Order order2 = new("Sourdough for Panera", "10 loaves", 150);
            Order expected = order2;
            Assert.AreEqual(expected, Order.FindOrder(2));
        }
        [TestMethod]
        public void GetAll_ReturnOrderAllOrders_List()
        {
            Order order1 = new("Croissants for Suzie's Cafe", "5 dozen croissants", 100);
            Order order2 = new("Sourdough for Panera", "10 loaves", 150);
            List<Order> expected = new() { order1, order2 };
            CollectionAssert.AreEqual(expected, Order.GetAll());
        }
    }
}

//title, description, price, date, id 
