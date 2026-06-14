namespace MintyOrderApi.Models
{
    public class FoodOrderItem
    {
        public int Id { get; set; } // Identity column, do not set on insert
        public string Name { get; set; } = string.Empty;

        // Foreign key
        public int FoodOrderId { get; set; }

        // Navigation property
        public FoodOrder? FoodOrder { get; set; }
    }
}
