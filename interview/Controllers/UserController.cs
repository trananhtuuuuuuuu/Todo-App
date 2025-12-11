using interview.Dtos.users;
using interview.Requests;
using interview.Responses;
using interview.Services;
using Microsoft.AspNetCore.Mvc;

namespace interview.Controllers;


[ApiController]
[Route("api/users")]
public class UserController : ControllerBase{
    
    private readonly UserService _userService;
    
    public UserController(UserService userService) {
        _userService = userService;
    }
    
    [HttpGet]
    public ActionResult<string> Get() {
        return Ok("Hello World");
    }
    
    
    [HttpPost]
    public async Task<ActionResult<ApiFormatResponse<UserResponseDTOs>>> CreateNewUser(
        CreateNewUserRequest createNewUserRequest
        ) {
        ApiFormatResponse<UserResponseDTOs> apiFormatResponse = new ApiFormatResponse<UserResponseDTOs>();
        UserResponseDTOs userResponseDtOs = await this._userService.CreateUserAsync(createNewUserRequest);
        
        apiFormatResponse.Data = userResponseDtOs;
        apiFormatResponse.Message = "Successfully";
        apiFormatResponse.StatusCode =  StatusCodes.Status201Created;
        
        return StatusCode(StatusCodes.Status201Created, apiFormatResponse);
        
    }
}