using interview.Responses;
using Microsoft.AspNetCore.Mvc;

namespace interview.Controllers;


[ApiController]
[Route("api/users")]
public class UserController : ControllerBase{
    [HttpGet]
    public ActionResult<string> Get() {
        return Ok("Hello World");
    }
    
    
    [HttpPost]
    public ActionResult<object> Post() {
        ApiFormatResponse response = new ApiFormatResponse();
        
        return null;
    }
}