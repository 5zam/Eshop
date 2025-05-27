using System.Reflection;
using EcommerceDay1.Models;
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

        public DbSet<Product> products_tb { get; set; }
        public DbSet<Customer> Customer_tb_ {  get; set; }
        public DbSet<Category> Category_tb { get; set; }
        public DbSet<Order> Order_tb_ { get; set; }
        public DbSet<OrderItem> OrderItem_tb_ { get; set; }
        public DbSet<PaymentInformation> PaymentInformation_tb_ { get; set; }
        public DbSet<Review> Review_tb_ { get;set; }

    }
}
