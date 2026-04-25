using activity_w5_library.Service;
using Microsoft.AspNetCore.Mvc;

namespace activity_w5_library.Controllers;

public class UserController:Controller
{
    private readonly UserServices _users;

    public UserController(UserServices users)
    {
        _users = users;
    }
}