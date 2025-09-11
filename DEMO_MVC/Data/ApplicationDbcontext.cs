using Microsoft.EntityFrameworkCore;
using DEMO_MVC.Models;

namespace DEMO_MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
    }
}
