using interview.Dtos.users;
using interview.Models;
using interview.Requests;

namespace interview.Mappers;

public class UserMapper {
    public static User toModels(CreateNewUserRequest createNewUserRequest) {
        return new User(
            createNewUserRequest.Name,
            createNewUserRequest.Username,
            createNewUserRequest.Password,
            createNewUserRequest.Email,
            createNewUserRequest.Phone,
            createNewUserRequest.Address, 
            createNewUserRequest.Gender
        );
    }


    public static UserResponseDTOs? toUserResponseDTOs(User user) {
        if (user.Role != null){
            
            return new UserResponseDTOs(
                user.Name,
                user.Username,
                user.Email,
                user.Phone,
                user.Address,
                user.Gender,
                user.Role.RoleName
            );
            
        }
        return null;
    }

}