using EcommerceDay1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceDay1.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        void IEntityTypeConfiguration<Order>.Configure(EntityTypeBuilder<Order> builder)
        {
            //throw new NotImplementedException();
            builder.HasOne(o => o.ShippingAddress)
            .WithMany(s => s.Orders)
            .HasForeignKey(o => o.Address_ID)
            .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
