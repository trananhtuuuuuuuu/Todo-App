using interview.Dtos.roles;
using interview.Mappers;
using interview.Models;
using interview.Requests.Roles;


namespace interview.Services;

public class RoleService {
    private readonly Repositories.RoleRepository _roleRepository;
    
    
    public RoleService(Repositories.RoleRepository roleRepository) {
        _roleRepository = roleRepository;
    }
    
    public async Task<IEnumerable<Models.Role>> GetAllRolesAsync() {
        return await _roleRepository.GetAllAsync();
    }
    
    
    public async Task<Models.Role?> GetRoleByIdAsync(int id) {
        return await _roleRepository.GetByIdAsync(id);
    }
    
    public async Task<Role?> GetRoleByNameAsync(string roleName) {
        return await _roleRepository.GetByNameAsync(roleName);
    }
    
    
    public async Task<RoleResponseDTOs> CreateRoleAsync(CreateNewRoleRequest roleRequest) {

        var role = RoleMapper.toModels(roleRequest);
        Role roleFromDb =  await _roleRepository.CreateAsync(role);
        
        RoleResponseDTOs roleResponseDtOs = RoleMapper.toRoleResponseDTOs(roleFromDb);
        
        return roleResponseDtOs;
    }
    
    
    public async Task UpdateRoleAsync(Models.Role role) {
        await _roleRepository.UpdateAsync(role);
    }
    
    public async Task DeleteRoleAsync(int id) {
        await _roleRepository.DeleteAsync(id);
    }
    
    
}