using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BibliofilAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext (DbContextOptions <ApplicationDbContext> options) : base(options)
        {   
        }

        public DbSet<BibliofilAPI.Models.LibraryUser> LibraryUsers { get; set; } = default!;
        public DbSet<BibliofilAPI.Models.Book> Books { get; set; } = default!;
        public DbSet<BibliofilAPI.Models.Loan> Loans { get; set; } = default!;
    }
}