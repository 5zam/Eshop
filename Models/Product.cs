namespace EcommerceDay1.Models
{
    public class Product
    {
        public int Product_ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
