using Microsoft.AspNetCore.Mvc;
using interview.Dtos.roles;
using interview.Requests.Roles;
using interview.Responses;
using interview.Services;
using Microsoft.AspNetCore.Http;


namespace interview.Controllers;

[ApiController]
[Route("api/roles")]
public class RoleController : ControllerBase{
    private readonly RoleService _roleService;
    
    public RoleController(RoleService roleService) {
        _roleService = roleService;
    }
    
    [HttpPost]
    public async Task<ActionResult<ApiFormatResponse<RoleResponseDTOs>>> CreateNewRoleAsync([FromBody] CreateNewRoleRequest roleRequest) {

        RoleResponseDTOs roleResponseDtOs = await this._roleService.CreateRoleAsync(roleRequest);
        ApiFormatResponse<RoleResponseDTOs> apiFormatResponse = new ApiFormatResponse<RoleResponseDTOs>();
        
        apiFormatResponse.Data = roleResponseDtOs;
        apiFormatResponse.Message = "Successfully";
        apiFormatResponse.StatusCode =  StatusCodes.Status201Created;

        return StatusCode(StatusCodes.Status201Created, apiFormatResponse);

    }
    
    
    
}