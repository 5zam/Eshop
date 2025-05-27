namespace EcommerceDay1.Models
{
    public class ShippingAddress
    {
        public int AddressID { get; set; }
        public int Customer_ID { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? PostalCode { get; set; }

        public Customer? Customer { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
