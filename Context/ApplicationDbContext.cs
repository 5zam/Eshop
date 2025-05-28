using System.Reflection;
using Azure;
using EcommerceDay1.Models;
using EcommerceDay1.Models.CustomerModels;
using EcommerceDay1.Models.OrderModels;
using EcommerceDay1.Models.ProductModels;
using Microsoft.EntityFrameworkCore;

namespace EcommerceDay1.Context
{
    public class ApplicationDbContext : DbContext
    {
       
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Product> products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> tags { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderItem> orderItems { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<ShippingAddress> shippingAddresses { get; set; }
        public DbSet<Review> reviews { get; set; }
        //public DbSet<PaymentInformation> PaymentInformation_tb_ { get; set; }
        public DbSet<Review> Review_tb_ { get;set; }

    }
}
