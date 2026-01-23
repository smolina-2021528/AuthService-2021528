using AuthServiceIN6BM.Domain.Entities;

namespace AuthServiceIN6BM.Application.Interfaces;

public interface IJwtTokenService
{
    string GenerateToken (User user);
}