using activity_w5_library.Models;
using Microsoft.EntityFrameworkCore;

namespace activity_w5_library.DataConfig;

public class MysqlDbContext : DbContext
{
    public MysqlDbContext(DbContextOptions<MysqlDbContext> options) : base(options)
    {
        
    }
    
   public DbSet<User> users { get; set; }
   public DbSet<Book> books { get; set; }
    
}