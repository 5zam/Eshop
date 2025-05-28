using System.ComponentModel.DataAnnotations.Schema;
using EcommerceDay1.Models.OrderModels;
using EcommerceDay1.Models.ProductModels;
using Microsoft.EntityFrameworkCore;

namespace EcommerceDay1.Models.CustomerModels
{
    public class Review
    {
        public int Id { get; set; }
        public int NoOfStart { get; set; }
        public string? Comments { get; set; }


        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; }
        public int Customer_ID { get; set; }

        [ForeignKey("orderId")]
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Order? order { get; set; }
        public int orderId { get; set; }

    }
}
