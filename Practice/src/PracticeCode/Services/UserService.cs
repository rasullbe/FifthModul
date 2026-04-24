using PracticeCode.Dtos;
using PracticeCode.Entities;

namespace PracticeCode.Services;

public class UserService : IUserService
{
    public Guid CreateUser(UserCreateDto userCreateDto)
    {
                
    }

    public bool DeleteUserAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public List<UserGetDto> GetAllUsersAsync()
    {
        throw new NotImplementedException();
    }

    public UserGetDto? GetUserById(Guid userId)
    {
        throw new NotImplementedException();
    }

    public bool UpdateUserAsync(Guid userId, UserUpdateDto userUpdateDto)
    {
        throw new NotImplementedException();
    }
}
