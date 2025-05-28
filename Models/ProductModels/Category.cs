namespace EcommerceDay1.Models.ProductModels
{
    public class Category
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }


        public IEnumerable<Product> Products { get; set; } = new List<Product>();
    }
}
