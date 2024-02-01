using Microsoft.EntityFrameworkCore;
using WiffyManagementWithAuthentication.Data;

namespace WiffyManagementWithAuthentication.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
