using Microsoft.EntityFrameworkCore;
using Zend.Models;

namespace Zend.Data
{
    public class ZendDbContext : DbContext
    {
       public ZendDbContext(DbContextOptions<ZendDbContext> options): base(options) { 
       }
        
        public DbSet<Estado> Estado { get; set; }

        public DbSet<User> User { get; set; }
    }
}
