using System.ComponentModel.DataAnnotations;

namespace AuthServiceIN6BM.Application.DTOs.Email;

public class VerifyEmailDto
{
    [Required]
    public string Token {get; set;} = string.Empty;
}