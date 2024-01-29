using System.Collections.Generic;
using System;
using System.Linq;

namespace VendorOrderTracker.Models
{
    public class Order
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public bool Fulfilled { get; set; }
        public string Date { get; }
        public int Id { get; }
        private static List<Order> _instances = new List<Order> { };

        public Order(string title, string description, int price)
        {
            Title = title;
            Description = description;
            Price = price;
            Date = DateTime.Today.ToString("d");
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static List<Order> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Order FindOrder(int searchId)
        {
            Order target = _instances.FirstOrDefault(order => order.Id == searchId);
            return target;
        }
    }
}