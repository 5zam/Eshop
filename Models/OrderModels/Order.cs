using System.ComponentModel.DataAnnotations.Schema;
using EcommerceDay1.Models.CustomerModels;
using EcommerceDay1.Models.OrderModels.Enums;

namespace EcommerceDay1.Models.OrderModels
{
    public class Order
    {
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public string? PaymentReference { get; set; }
        public OrderStatus statusOrder { get; set; }
        public DateTime CreatedAt { get; set; }


        public IEnumerable<OrderItem> orderItems { get; set; } = new List<OrderItem>();

        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
