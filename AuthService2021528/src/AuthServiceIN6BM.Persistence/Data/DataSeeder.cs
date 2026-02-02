using AuthServiceIN6BM.Domain.Entities;
using AuthServiceIN6BM.Application.Services;
using AuthServiceIN6BM.Domain.Constants;
using Microsoft.EntityFrameworkCore;

namespace AuthServiceIN6BM.Persistence.Data;

public static class DataSeeder
{
    public static async Task SeedAsync(ApplicationDbContext context)
    {
        if (!context.Roles.Any())
        {
            var roles = new List<Role>
            {
                new()
                {
                    Id = UuidGenerator.GenerateRoleId(),
                        Name = RoleConstants.ADMIN_ROLE
                },
                new()
                {
                    Id = UuidGenerator.GenerateRoleId(),
                        Name = RoleConstants.USER_ROLE
                }
            };
        }
    }
}