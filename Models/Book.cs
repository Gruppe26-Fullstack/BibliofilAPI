using System.ComponentModel.DataAnnotations;

namespace BibliofilAPI.Models;

public class Book
{
    public int Id { get; set; }

    [RegularExpression(@"^(978|979)\d{10}$")]
    [Required]
    public string? ISBN { get; set; }

    [StringLength(60, MinimumLength = 1)]
    [Required]
    public string? Title { get; set; }

    [StringLength(60, MinimumLength = 1)]
    [RegularExpression(@"^[A-Za-z]+([ .'-][A-Za-z]+)*\.?$")]
    public string? Author { get; set; }

    [Range(0, 3000, ErrorMessage = "Year must be between 0 and 3000")]
    [Display (Name = "Year Published")]
    public int YearPublished { get; set; }

    [Display (Name = "Is Available")]
    public bool IsAvailable { get; set; }
}