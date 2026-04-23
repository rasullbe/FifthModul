using PracticeCode.Dtos;
using PracticeCode.Entities;

namespace PracticeCode.Services;

public interface IUserService
{
    public List<UserGetDto> GetAllUsersAsync();
    public Guid CreateUser(UserCreateDto userCreateDto);
    public bool UpdateUserAsync(Guid userId, UserUpdateDto userUpdateDto);   
    public UserGetDto? GetUserById(Guid userId);
    public bool DeleteUserAsync(Guid userId);

}