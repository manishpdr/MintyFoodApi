using System;
using System.Collections.Generic;

namespace MintyOrderApi.Models
{
    public class FoodOrder
    {
        public int Id { get; set; } // Identity column, do not set on insert
        public string CustomerName { get; set; } = string.Empty;
        public DateTime OrderTime { get; set; } = DateTime.UtcNow;

        // Navigation property
        public List<FoodOrderItem> Items { get; set; } = new();
    }
}