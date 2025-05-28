using EcommerceDay1.Models.ProductModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceDay1.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        void IEntityTypeConfiguration<Category>.Configure(EntityTypeBuilder<Category> builder)
        {
            //throw new NotImplementedException();
            //builder.HasKey(c => c.CategoryID);
            builder.Property(c => c.CategoryName).HasMaxLength(50);
        }
    }
}
