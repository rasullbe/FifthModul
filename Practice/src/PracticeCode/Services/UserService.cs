using PracticeCode.Dtos;
using PracticeCode.Entities;

namespace PracticeCode.Services;

public class UserService : IUserService
{
    private static List<User> _users = [];

    public Guid CreateUser(UserCreateDto userCreateDto)
    {
        var userId = Guid.NewGuid();
        var user = new User
        {
            UserId = userId,
            FirstName = userCreateDto.FirstName,
            LastName = userCreateDto.LastName,
            Email = userCreateDto.Email,
            Password = userCreateDto.Password,
            PhoneNumber = userCreateDto.PhoneNumber,
            DateOfBirth = userCreateDto.DateOfBirth
        };

        _users.Add(user);
        return userId;
    }

    public bool DeleteUserAsync(Guid userId)
    {
        var user = _users.FirstOrDefault(u => u.UserId == userId);
        if (user == null)
            return false;

        _users.Remove(user);
        return true;
    }

    public List<UserGetDto> GetAllUsersAsync()
    {
        return _users.Select(u => new UserGetDto
        {
            UserId = u.UserId,
            FirstName = u.FirstName,
            LastName = u.LastName,
            Email = u.Email,
            PhoneNumber = u.PhoneNumber,
            DateOfBirth = u.DateOfBirth
        }).ToList();
    }

    public UserGetDto? GetUserById(Guid userId)
    {
        var user = _users.FirstOrDefault(u => u.UserId == userId);
        if (user == null)
            return null;

        return new UserGetDto
        {
            UserId = user.UserId,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            PhoneNumber = user.PhoneNumber,
            DateOfBirth = user.DateOfBirth
        };
    }

    public bool UpdateUserAsync(Guid userId, UserUpdateDto userUpdateDto)
    {
        var user = _users.FirstOrDefault(u => u.UserId == userId);
        if (user == null)
            return false;

        user.FirstName = userUpdateDto.FirstName;
        user.LastName = userUpdateDto.LastName;
        user.Email = userUpdateDto.Email;
        user.PhoneNumber = userUpdateDto.PhoneNumber;
        user.DateOfBirth = userUpdateDto.DateOfBirth;

        return true;
    }
}
