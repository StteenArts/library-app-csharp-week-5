using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using activity_w5_library.Models;
using activity_w5_library.Service;
using activity_w5_library.viewModels;

namespace activity_w5_library.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly BookServices _bookService;
    private readonly UserServices _userService;
    


    public HomeController(
        ILogger<HomeController> logger,
        BookServices bookService,
        UserServices userService) 
    {
        _logger = logger;
        _bookService = bookService;
        _userService = userService;
    }
    
    public IActionResult Index()
    {
        var responseBooks = _bookService.GetAllBooks();
        var responseUsers = _userService.GetAllUsers();
        var model = new DashboardViewModel
        {
            Books = responseBooks.Data.ToList(),
            Users = responseUsers.Data.ToList()
        };
        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
