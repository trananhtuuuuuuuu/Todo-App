using System.ComponentModel.DataAnnotations;

namespace interview.Requests.Roles;

public class CreateNewRoleRequest {
    [Required(ErrorMessage =  "Role Name is required")]
    public string RoleName { get; set; } = "";
    
    [Required(ErrorMessage =  "Role Description is required")]
    public string Description { get; set; } = "";
}