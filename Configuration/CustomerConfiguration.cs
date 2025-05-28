using EcommerceDay1.Models.CustomerModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceDay1.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        void IEntityTypeConfiguration<Customer>.Configure(EntityTypeBuilder<Customer> builder)
        {
            //throw new NotImplementedException();
            //builder.HasKey(c => c.Customer_ID);

            //builder.Property(c => c.Name).HasMaxLength(100).IsRequired();
            //builder.Property(c => c.Email_address).HasMaxLength(100).IsRequired();
            //builder.Property(c => c.Contact_Information).HasMaxLength(20);

            //builder.HasMany(c => c.ShippingAddresses)
            //       .WithOne(s => s.Customer)
            //       .HasForeignKey(s => s.Customer_ID);

            //builder.HasMany(c => c.PaymentInformations)
            //       .WithOne(p => p.Customer)
            //       .HasForeignKey(p => p.Customer_ID);

            //builder.HasMany(c => c.Orders)
            //       .WithOne(o => o.Customer)
            //       .HasForeignKey(o => o.Customer_ID);

            //builder.HasMany(c => c.Reviews)
            //       .WithOne(r => r.Customer)
            //       .HasForeignKey(r => r.Customer_ID);
        }
    }
}
