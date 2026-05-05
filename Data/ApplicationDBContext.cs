using Microsoft.EntityFrameworkCore;

namespace BibliofilAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions <ApplicationDbContext> options) : base(options)
        {   
        }

        public DbSet<BibliofilAPI.Models.User> Users { get; set; } = default!;
        public DbSet<BibliofilAPI.Models.Book> Books { get; set; } = default!;
        public DbSet<BibliofilAPI.Models.Loan> Loans { get; set; } = default!;
    }
}