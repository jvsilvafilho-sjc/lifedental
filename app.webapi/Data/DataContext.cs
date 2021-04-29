using Microsoft.EntityFrameworkCore;
using app.webapi.Model;

namespace app.webapi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Categories> Category { get; set; }
        public DbSet<Customers> Customer { get; set; }
        public DbSet<Natural_person> Natural_person { get; set; }
        public DbSet<Products> Products { get; set; }
       
    }
}