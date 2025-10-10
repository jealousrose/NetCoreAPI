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

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Employee> HeThongPhanPhoi { get; set; }

        public DbSet<DaiLy> DaiLys { get; set; }
        public DbSet<DEMO_MVC.Models.HeThongPhanPhoi> HeThongPhanPhoi_1 { get; set; } = default!;
    }
}
