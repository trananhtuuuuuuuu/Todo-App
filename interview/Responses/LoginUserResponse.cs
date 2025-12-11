namespace interview.Responses;

public class LoginUserResponse {
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Token { get; set; } = string.Empty; // JWT token
    public string RoleName { get; set; } = string.Empty;
}