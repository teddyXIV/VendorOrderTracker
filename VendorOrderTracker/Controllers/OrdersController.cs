using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
    public class OrdersController : Controller
    {
        [HttpGet("/vendors/{vendorId}/orders/new")]
        public ActionResult New(int vendorId)
        {
            Vendor vendor = Vendor.FindVendor(vendorId);
            return View(vendor);
        }

        [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
        public ActionResult Show(int vendorId, int orderId)
        {
            Order order = Order.FindOrder(orderId);
            Vendor vendor = Vendor.FindVendor(vendorId);
            Dictionary<string, object> model = new()
            {
                { "vendor", vendor },
                { "order", order }
            };
            return View(model);
        }

        [HttpPost("/vendors/{vendorId}/orders/{orderId}")]
        public ActionResult Destroy(int vendorId, int orderId)
        {
            Vendor selectedVendor = Vendor.FindVendor(vendorId);
            Order selectedOrder = Order.FindOrder(orderId);
            selectedVendor.Orders.Remove(selectedOrder);
            Order.GetAll().Remove(selectedOrder);
            return RedirectToAction("Show", "Vendors", new { id = vendorId });
        }
    }
}

// return RedirectToAction("Show", "VendorsController", new { id = vendorId });