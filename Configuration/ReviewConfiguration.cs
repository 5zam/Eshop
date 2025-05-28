using EcommerceDay1.Models.CustomerModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceDay1.Configuration
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        void IEntityTypeConfiguration<Review>.Configure(EntityTypeBuilder<Review> builder)
        {
            ////throw new NotImplementedException();
            //builder.HasKey(r => r.ReviewID);
            //builder.Property(r => r.Comments).HasMaxLength(200);

            //builder.HasOne(r => r.Customer)
            //       .WithMany(c => c.Reviews)
            //       .HasForeignKey(r => r.Customer_ID);

            //builder.HasOne(r => r.Product)
            //       .WithMany(p => p.Reviews)
            //       .HasForeignKey(r => r.Product_ID);

        }
    }
}
  

