using System.ComponentModel.DataAnnotations;

namespace AuthServiceIN6BM.Application.DTOs;

public class GetProfileByIdDto
{
    [Required(ErrorMessage = "El UserId es requerido")]
    public string UserId { get; set; } = string.Empty;
}