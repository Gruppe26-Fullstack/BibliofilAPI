using System.ComponentModel.DataAnnotations;

namespace BibliofilAPI.Models;

public class Loan
{
    public int Id { get; set; }

    [Display (Name = "Loan Date")]
    [Required]
    public DateTime LoanDate { get; set; }

    public int UserId { get; set; }
    public int BookId { get; set; }
    public User? User { get; set; }
    public Book? Book { get; set; }
}