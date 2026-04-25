using activity_w5_library.DataConfig;
using activity_w5_library.Models;
using activity_w5_library.Response;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace activity_w5_library.Service;

public class BookServices
{
    private readonly MysqlDbContext _dbContext;

    public BookServices(MysqlDbContext context)
    {
        _dbContext = context;
    }

    public BookResponse<IEnumerable<Book>> GetAllBooks()
    {
        var books = _dbContext.books.ToList();
        return new BookResponse<IEnumerable<Book>>()
        {
            Data = books,
            Success = true,
        };
    }
}