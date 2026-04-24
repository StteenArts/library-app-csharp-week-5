using activity_w5_library.DataConfig;
using Microsoft.EntityFrameworkCore;

namespace activity_w5_library.Service;

public class UserServices : DbContext
{
    private readonly MysqlDbContext _dbContext;
    
    public  UserServices(MysqlDbContext context)
    {
        _dbContext = context;
    }
    
    
}