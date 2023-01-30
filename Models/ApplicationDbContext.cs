using Microsoft.EntityFrameworkCore;

namespace ExportExcel_in_ASPNetCore.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<BlackCoder> blackcoder { get; set; }
    }
}