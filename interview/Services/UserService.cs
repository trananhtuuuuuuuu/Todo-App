using interview.Repositories;

namespace interview.Services;

public class UserService {
    private readonly UserRepository _userRepository;
    
    public UserService(UserRepository userRepository) {
        _userRepository = userRepository;
    }
    
    public async Task<IEnumerable<Models.User>> GetAllUsersAsync() {
        return await _userRepository.GetAllAsync();
    }
    
    public async Task<Models.User?> GetUserByIdAsync(int id) {
        return await _userRepository.GetByIdAsync(id);
    }
    
    public async Task<Models.User> CreateUserAsync(Models.User user) {
        return await _userRepository.CreateAsync(user);
    }
    
    public async Task UpdateUserAsync(Models.User user) {
        await _userRepository.UpdateAsync(user);
    }
    
    public async Task DeleteUserAsync(int id) {
        await _userRepository.DeleteAsync(id);
    }
    
}