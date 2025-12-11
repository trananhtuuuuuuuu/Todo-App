using interview.Dtos.users;
using interview.Mappers;
using interview.Models;
using interview.Repositories;
using interview.Requests;

namespace interview.Services;

public class UserService {
    private readonly UserRepository _userRepository;
    private readonly RoleService _roleService;
    
    public UserService(UserRepository userRepository, RoleService roleService) {
        _userRepository = userRepository;
        this._roleService = roleService;
    }
    
    public async Task<IEnumerable<Models.User>> GetAllUsersAsync() {
        return await _userRepository.GetAllAsync();
    }
    
    public async Task<Models.User?> GetUserByIdAsync(int id) {
        return await _userRepository.GetByIdAsync(id);
    }
    
    public async Task<UserResponseDTOs> CreateUserAsync(CreateNewUserRequest createNewUserRequest) {
        
        User user = UserMapper.toModels(createNewUserRequest);
        var role = await this._roleService.GetRoleByNameAsync(createNewUserRequest.RoleName);
        
        if (role == null) {
            throw new Exception($"Role '{createNewUserRequest.RoleName}' not found");
        }
        
        user.RoleId = role.RoleId;

        
        var userFromDb = await _userRepository.CreateAsync(user);
        
        var userResponseDtOs = UserMapper.toUserResponseDTOs(userFromDb);
        
        return userResponseDtOs ?? throw new Exception("Error mapping User to UserResponseDTOs");
    }
    
    public async Task UpdateUserAsync(Models.User user) {
        await _userRepository.UpdateAsync(user);
    }
    
    public async Task DeleteUserAsync(int id) {
        await _userRepository.DeleteAsync(id);
    }
    
}