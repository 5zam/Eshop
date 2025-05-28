using System.Net.Http.Headers;
using EcommerceDay1.Models.ProductModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceDay1.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        void IEntityTypeConfiguration<Product>.Configure(EntityTypeBuilder<Product> builder)
        {
            //builder.Property(p => p.Name)
            //     .IsRequired()
            //     .HasMaxLength(30);

            //builder.Property(p => p.Description)
            //     .IsRequired(false);

            //builder.Property(P => P.Price)
            //    .HasPrecision(10, 3);

            //builder.Property(p =>p.imageURL)
            //    .IsRequired(false);

            //builder.HasKey(p => p.Product_ID);

            //builder.Property(p => p.Name).HasMaxLength(100);
            //builder.Property(p => p.Description).HasMaxLength(100);
            //builder.Property(p => p.Price).HasColumnType("decimal(10,2)");

            //builder.HasOne(p => p.Category)
            //       .WithMany(c => c.Products)
            //       .HasForeignKey(p => p.CategoryID);


        }
    }
}
