using Microsoft.EntityFrameworkCore;
using TESTSIX.Models;

namespace TESTSIX.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options ):base(options)
        {



        }
        
        public DbSet<Category> categories { get; set; }
        public DbSet<CoverType> CoverTypes { get; set; }

    }
}
