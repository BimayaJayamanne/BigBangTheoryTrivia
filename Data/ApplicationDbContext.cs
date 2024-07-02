using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BigBangTheoryTrivia.Models;

namespace BigBangTheoryTrivia.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BigBangTheoryTrivia.Models.Questions> Questions { get; set; } = default!;
    }
}
