namespace EcommerceDay1.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int Product_ID { get; set; }
        public Product? Product { get; set; }
        public int Customer_ID { get; set; }
        public Customer? Customer { get; set; }
        public int Rating { get; set; }
        public string? Comments { get; set; }
    }
}
