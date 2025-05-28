using System.ComponentModel.DataAnnotations.Schema;
using Azure;
using EcommerceDay1.Models.CustomerModels;
using EcommerceDay1.Models.OrderModels;

namespace EcommerceDay1.Models.ProductModels
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public int Stock { get; set; }

        [ForeignKey("CategoryID")]
        public int CategoryID { get; set; }
        public Category? Category { get; set; }

        //link product with Tag - one tag has many Product
        public IEnumerable<Tag> tags { get; set; } = new List<Tag>();

        //public ICollection<OrderItem>? OrderItems { get; set; }
        //public ICollection<Review>? Reviews { get; set; }
    }
}
