using System.ComponentModel.DataAnnotations;
using EcommerceDay1.Models.OrderModels;

namespace EcommerceDay1.Models.CustomerModels
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        [EmailAddress]
        public string? Email_address { get; set; }
        public int? Contact_Information { get; set; }

        public int NumberOfOrder { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation properties
        //public ICollection<ShippingAddress> ShippingAddresses { get; set; }
        //public ICollection<PaymentInformation> PaymentInformations { get; set; }
        public IEnumerable<Review> reviews { get; set; } = new List<Review>();
        public IEnumerable<ShippingAddress> shippingAddresses { get; set; } = new List<ShippingAddress>();
        public IEnumerable<Order> orders { get; set; } = new List<Order>();
    }
}
