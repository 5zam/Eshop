using System.ComponentModel.DataAnnotations.Schema;
using EcommerceDay1.Models.OrderModels;

namespace EcommerceDay1.Models.CustomerModels
{
    public class ShippingAddress
    {
        public int Id { get; set; }
        
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? BuildingNumber { get; set; }
        public string? Remark { get; set; }


        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; }
        public int Customer_ID { get; set; }

       
    }
}
