namespace EcommerceDay1.Models.ProductModels
{
    public class Tag
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        //link tag with Product - one product has many Tag
        public IEnumerable<Product> products { get; set; } = new List<Product>();
    }
}
