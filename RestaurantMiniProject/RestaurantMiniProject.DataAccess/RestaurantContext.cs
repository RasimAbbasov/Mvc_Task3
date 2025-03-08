using Microsoft.EntityFrameworkCore;
using RestaurantMiniProject.Core.Models;

namespace RestaurantMiniProject.DataAccess
{
    internal class RestaurantContext:DbContext
    {
        public DbSet<MenuItem> menuItems { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderItem> orderItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-Q262GML\\SQLEXPRESS01;Database=RestaurantMiniProject;Trusted_Connection=True;TrustServerCertificate=True");
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfigurationsFromAssembly()
        //}
    }
}
