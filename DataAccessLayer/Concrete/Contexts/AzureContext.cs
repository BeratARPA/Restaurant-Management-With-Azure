using EntityLayer.Concrete;
using System.Data.Entity;

namespace DataAccessLayer.Concrete.Contexts
{
    public class AzureContext : DbContext
    {
        public AzureContext() : base("AzureContext")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}
