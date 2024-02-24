using ASP.NET_Task.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Task.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee>? Employees { get; set; }
    }
}
