using System.Collections.Generic;
using System;
using System.Linq;

namespace VendorOrderTracker.Models
{
    public class Vendor
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Order> Orders { get; set; }
        public int Id { get; }
        private static List<Vendor> _instances = new() { };

        public Vendor(string name, string description)
        {
            Name = name;
            Description = description;
            _instances.Add(this);
            Id = _instances.Count;
            Orders = new() { };
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static List<Vendor> GetAll()
        {
            return _instances;
        }

        public static Vendor FindVendor(int searchId)
        {

            Vendor target = _instances.FirstOrDefault(vendor => vendor.Id == searchId);
            return target;
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
    }
}