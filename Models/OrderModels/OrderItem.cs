using System.ComponentModel.DataAnnotations.Schema;
using EcommerceDay1.Models.ProductModels;

namespace EcommerceDay1.Models.OrderModels
{
    public class OrderItem
    {
        public int Id { get; set; }


        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }


        [ForeignKey("OrderID")]
        public Order? Order { get; set; }
        public int OrderID { get; set; }


        [ForeignKey("ProductId")]
        public Product? product { get; set; }
        public int ProductId { get; set; }
    }
}
