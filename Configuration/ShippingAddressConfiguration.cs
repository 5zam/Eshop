using EcommerceDay1.Models.CustomerModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceDay1.Configuration
{
    public class ShippingAddressConfiguration : IEntityTypeConfiguration<ShippingAddress>
    {
        void IEntityTypeConfiguration<ShippingAddress>.Configure(EntityTypeBuilder<ShippingAddress> builder)
        {
            //throw new NotImplementedException();
            //builder.HasKey(s => s.AddressID);

            //builder.Property(s => s.Street).HasMaxLength(100);
            //builder.Property(s => s.City).HasMaxLength(50);
            //builder.Property(s => s.Country).HasMaxLength(50);
            //builder.Property(s => s.PostalCode).HasMaxLength(10);

            //builder.HasMany(s => s.Orders)
            //       .WithOne(o => o.ShippingAddress)
                   //.HasForeignKey(o => o.Address_ID);
        }
    }
}
