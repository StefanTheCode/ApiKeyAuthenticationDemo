using ApiKeyAuthentication.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace ApiKeyAuthentication.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    public UserController()
    {
    }

    [ApiKey]
    [HttpGet(Name = "GetAllUsers")]
    public List<string> GetAll()
    {
        return new List<string> { "Stefan" };
    }
}