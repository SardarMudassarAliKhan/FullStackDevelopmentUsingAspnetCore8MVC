using FullStackDevelopmentUsingAspnetCore8MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace FullStackDevelopmentUsingAspnetCore8MVC.ApplicationDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
