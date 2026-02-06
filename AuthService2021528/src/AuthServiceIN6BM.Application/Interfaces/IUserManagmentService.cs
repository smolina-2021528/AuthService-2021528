using AuthServiceIN6BM.Application.DTOs;

namespace AuthServiceIN6BM.Application.Interfaces;

public interface IUserManagmentService
{
    Task <UserResponseDto> UpdateUserRoleAsync(string userId, string roleName);
    Task<IReadOnlyList<string>> GetUserRolesAsync(string userId);

}