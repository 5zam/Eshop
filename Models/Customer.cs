namespace EcommerceDay1.Models
{
    public class Customer
    {
        public int Customer_ID { get; set; }
        public string Name { get; set; }
        public string Email_address { get; set; }
        public string Contact_Information { get; set; }

        // Navigation properties
        public ICollection<ShippingAddress> ShippingAddresses { get; set; }
        public ICollection<PaymentInformation> PaymentInformations { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
