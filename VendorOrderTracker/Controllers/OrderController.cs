using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Models
{
    public class Order
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Date { get; }

        public Order(string title, string description, int price)
        {
            Title = title;
            Description = description;
            Price = price;
            Date = DateTime.Today.ToString("d");
        }
    }
}