using Microsoft.AspNetCore.Mvc;

namespace BookCase.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : Controller
{
    [HttpGet("/{id}")]
    public Task<IActionResult> GetUserById()
    {
        throw new NotImplementedException();
    }
}