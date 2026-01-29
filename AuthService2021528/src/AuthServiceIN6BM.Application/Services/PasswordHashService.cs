using AuthServiceIN6BM.Application.Interfaces;
using Konscious.Security.Cryptography;
using System.Security.Cryptography;
using System.Text;

namespace AuthServiceIN6BM.Application.Services;

public class PasswordHashService : IPasswordHashService
{
    private const int SaltSize =16;
    private const int HashSize = 32;
    private const int Iterations = 2;
    private const int Memory = 102400;
    private const int Parallelism = 8;
    public string HashPassword(string password)
    {
        var salt = new Byte[SaltSize];
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(salt);
        }

        var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password))
        {
            Salt = salt,
            DegreeOfParallelism = Parallelism,
            Iterations = Iterations, 
            MemorySize = Memory
        };

        var hash = argon2.GetBytes(HashSize);

        var saltBase64 = Convert.ToBase64String(salt);
        var hashBase64 = Convert.ToBase64String(hash);

        return $"$argon2id$v=19$m={Memory},t={Iterations},p={Parallelism}${saltBase64}${hashBase64}";
    }

    public bool VerifyPassword(string password, string hashedPassword)
    {
        
    }
}