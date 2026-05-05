using System.ComponentModel.DataAnnotations;

namespace BibliofilAPI.Models;

public class Book
{
    [Display (Name = "Book ID")]
    public int Id { get; set; }

    [RegularExpression(@"^(978|979)\d{10}$", ErrorMessage = "ISBN must start with 979 or 978, and must be 13 digits long")]
    [Required]
    public string? ISBN { get; set; }

    [StringLength(60, MinimumLength = 1)]
    [Required]
    public string? Title { get; set; }

    [StringLength(60, MinimumLength = 1)]
    [RegularExpression(@"^[A-Za-zæøåÆØÅ .'-]+$", ErrorMessage = "Only letters, -, ' and . are permitted")]
    [Required]
    public string? Author { get; set; }

    [Range(0, 3000, ErrorMessage = "Year must be between 0 and 3000")]
    [Display (Name = "Year Published")]
    public int YearPublished { get; set; }

    [Display (Name = "Is Available")]
    public bool IsAvailable { get; set; }
}