using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace MilkParadiseShop.Model
{
    public class BaseContext : DbContext
    {
        public DbSet<JobRole> JobRoles { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProdInOrder> ProdsInOrders { get; set; }
        public DbSet<ClientProduct> ClientProducts { get; set; }

        public BaseContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["MilkParadiseShopBase"].ConnectionString);
    }
}