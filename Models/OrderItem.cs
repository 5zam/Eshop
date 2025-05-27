namespace EcommerceDay1.Models
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }

        public int OrderID { get; set; }
        public Order Order { get; set; }

        public int Product_ID { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public double ItemPrice { get; set; }
    }
}
