namespace EcommerceDay1.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int Customer_ID { get; set; }
        public int Address_ID { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }

        public Customer Customer { get; set; }
        public ShippingAddress ShippingAddress { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
