using Microsoft.AspNetCore.Mvc;

namespace activity_w5_library.Controllers;

public class LoginController:Controller
{
    public IActionResult Index()
    {
        return View();
    }
}