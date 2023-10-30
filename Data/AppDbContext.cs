using Microsoft.EntityFrameworkCore;
using WebApi_ASA.Data.Models;

namespace WebApi_ASA.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        
        public DbSet<Book> Books { get; set; }
    }
}
