namespace interview.Dtos.roles;

public class RoleResponseDTOs {
    public string RoleName { get; set; } = "";
    public string Description { get; set; } = "";
    public DateTime CreatedAt { get; set;  }

    public RoleResponseDTOs(string roleName, string description, DateTime createdAt) {
        RoleName = roleName;
        Description = description;
        CreatedAt = createdAt;
    }
}