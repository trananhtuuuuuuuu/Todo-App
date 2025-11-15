using Microsoft.AspNetCore.Mvc;

namespace interview.Controllers;


[ApiController]
[Route("api/users")]
public class UserController : ControllerBase{
    [HttpGet]
    public ActionResult<string> Get()
    {
        return Ok("Hello World");
    }
}