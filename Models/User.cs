using System.ComponentModel.DataAnnotations;

namespace BibliofilAPI.Models;

public class User
{
    [Display(Name = "User ID")]
    public int Id { get; set; }

    [Display (Name = "First Name")]
    [StringLength(30, MinimumLength = 1)]
    [RegularExpression("^[A-Za-zæøåÆØÅ .'-]+$", ErrorMessage = "Only letters, -, ' and . are permitted")]
    [Required]
    public string? FirstName { get; set; }

    [Display (Name = "Last Name")]
    [StringLength(30, MinimumLength = 1)]
    [RegularExpression("^[A-Za-zæøåÆØÅ .'-]+$", ErrorMessage = "Only letters, -, ' and . are permitted")]
    [Required]
    public string? LastName { get; set; }

    [StringLength(100, MinimumLength = 1)]
    [EmailAddress]
    [Required]
    public string? Email { get; set; }
}