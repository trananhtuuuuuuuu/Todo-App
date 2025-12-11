namespace interview.Dtos.users;

public class UserResponseDTOs {
    public string Name { get; set; } = "";
    public string Username { get; set; } = "";
    public string Email { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public string Address { get; set; } = "";
    public string Gender { get; set; } = "";
    public string RoleName { get; set; } = "";
    
    public UserResponseDTOs(string name, 
        string username, 
        string email, 
        string phoneNumber, 
        string address, 
        string gender, 
        string roleName){
        
        Name = name;
        Username = username;
        Email = email;
        PhoneNumber = phoneNumber;
        Address = address;      
        Gender = gender;
        RoleName = roleName;
        
    }
}