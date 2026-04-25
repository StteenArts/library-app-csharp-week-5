using activity_w5_library.DataConfig;
using activity_w5_library.Models;
using activity_w5_library.Response;
using Microsoft.EntityFrameworkCore;

namespace activity_w5_library.Service;

public class UserServices : DbContext
{
    private readonly MysqlDbContext _dbContext;
    
    public  UserServices(MysqlDbContext context)
    {
        _dbContext = context;
    }

    public UserResponse<IEnumerable<User>> GetAllUsers()
    {
        var users = _dbContext.users.ToList();
        return new UserResponse<IEnumerable<User>>()
        {
            Data = users,
            Success = true,
        };
        
    }
    
    
}