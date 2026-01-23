using AuthServiceIN6BM.Domain.Entities;
namespace AuthServiceIN6BM.Domain.Interfaces;

public interface IRoleRepository
{
    Task<Role?> GetByNameAsync(string name);
    Task<int> CountUsersInRoleAsync(string roleName);
    Task<IReadOnlyCollection<User>> GetUserByRoleAsync(string roleName);
    Task<IReadOnlyCollection<string>> GetUserRoleNamesAsync(string userId);
}