using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
    public class VendorsController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index(string searchString)
        {
            List<Vendor> allVendors = Vendor.GetAll();
            if (String.IsNullOrEmpty(searchString))
            {
                return View(allVendors);
            }
            else
            {
                IEnumerable<Vendor> searchResults = allVendors.Where(vendor => vendor.Name.ToLower() == searchString.ToLower());
                return View(searchResults);
            }
        }

        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/vendors")]
        public ActionResult Create(string vendorName, string vendorDescription)
        {
            Vendor newVendor = new(vendorName, vendorDescription);
            return RedirectToAction("Index");
        }

        [HttpGet("/vendors/{id}")]
        public ActionResult Show(int id)
        {
            Vendor selectedVendor = Vendor.FindVendor(id);
            List<Order> vendorOrders = selectedVendor.Orders;
            Dictionary<string, object> model = new()
            {
                { "vendor", selectedVendor },
                { "orders", vendorOrders }
            };
            return View(model);
        }

        [HttpPost("/vendors/{vendorId}/orders")]
        public ActionResult Create(int vendorId, string orderTitle, string orderDescription, string orderPrice)
        {
            Dictionary<string, object> model = new();
            Vendor foundVendor = Vendor.FindVendor(vendorId);
            Order newOrder = new(orderTitle, orderDescription, int.Parse(orderPrice));
            foundVendor.AddOrder(newOrder);
            List<Order> vendorOrders = foundVendor.Orders;
            model.Add("vendor", foundVendor);
            model.Add("orders", vendorOrders);
            return View("Show", model);
        }

        [HttpPost("/vendors/{id}")]
        public ActionResult Destroy(int vendorId)
        {
            Vendor selectedVendor = Vendor.FindVendor(vendorId);
            List<Vendor> allVendors = Vendor.GetAll();
            allVendors.Remove(selectedVendor);

            return RedirectToAction("Index");
        }

    }
}