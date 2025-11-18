using System.ComponentModel.DataAnnotations;

namespace interview.Requests;

public class CreateNewUserRequest {
    
    /*
      public string Name { get; set; } = "";
              public string Username { get; set; } = "";
              public string Password { get; set; } = "";
              public string Email { get; set; } = "";
              public string Phone { get; set; } = "";
              public string Address { get; set; } = "";
              public string Gender { get; set; } = "";

              public DateTime CreatedAt { get; set; }
    */
    
    [Required(ErrorMessage =  "Name is required")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
    public string Name { get; set; }
    
    [Required(ErrorMessage =  "Username is required")]
    [StringLength(30, MinimumLength = 4, ErrorMessage = "Username must be between 4 and 30 characters")]
    public string Username { get; set; }
    
    [Required(ErrorMessage =  "Password is required")]
    [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 100 characters")]
    public string Password { get; set; }
    
    [Required(ErrorMessage =  "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email address")]
    public string Email { get; set; }
    
    [Required(ErrorMessage =  "Phone is required")]
    [Phone(ErrorMessage = "Invalid phone number")]
    public string Phone { get; set; }
    
    [Required(ErrorMessage =  "Address is required")]
    public string Address { get; set; }
    
    [Required(ErrorMessage =  "Gender is required")]
    [RegularExpression("^(Male|Female|Other)$", ErrorMessage = "Gender must be 'Male', 'Female', or 'Other'")] 
    public string Gender { get; set; }
    
    [Required(ErrorMessage =  "RoleName is required")]
    public string RoleName { get; set; }
    //public DateTime CreatedAt { get; set; }
    
    public CreateNewUserRequest(string name, string username, string password, string email, string phone, string address, string gender, string roleName) {
        this.Name = name;
        this.Username = username;
        this.Password = password;
        this.Email = email;
        this.Phone = phone;
        this.Address = address;
        this.Gender = gender;
        this.RoleName = roleName;
    }
    
}