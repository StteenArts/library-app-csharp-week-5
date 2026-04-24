using activity_w5_library.Service;
using Microsoft.AspNetCore.Mvc;

namespace activity_w5_library.Controllers;

public class BookController : Controller
{
    private readonly BookServices _books;

    public BookController(BookServices books)
    {
        _books = books;
    }

    public IActionResult Index()
    {
        var books = _books.GetAllBooks();
        return View(books.Data);
    }
}