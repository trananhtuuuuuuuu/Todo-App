using interview.Dtos.roles;
using interview.Models;
using interview.Requests.Roles;

namespace interview.Mappers;

public class RoleMapper
{
    public static Role toModels(CreateNewRoleRequest roleRequest) {
        return new Role(
            roleRequest.RoleName,
            roleRequest.Description
        );
    }
    
    public static RoleResponseDTOs toRoleResponseDTOs(Role role) {
        return new RoleResponseDTOs(
            role.RoleName,
            role.RoleDescription,
            role.CreatedDate
        );
    }
    
}