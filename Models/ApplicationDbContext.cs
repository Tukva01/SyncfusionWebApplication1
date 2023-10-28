using System.Runtime.InteropServices;

using Microsoft.EntityFrameworkCore; // Для DbContext
using Microsoft.EntityFrameworkCore.SqlServer; // Для подключения к SQL Server

namespace SyncfusionWebApplication1.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Products = Set<Product>();
        }
    }
    
}
