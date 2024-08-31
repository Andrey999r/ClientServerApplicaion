using Microsoft.EntityFrameworkCore;
using MyNewWebsite.Models;

namespace MyNewWebsite.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        //public DbSet<Tasks> Task { get; set; }
        public DbSet<Users> User { get; set; }
        public DbSet<Tasks> Task { get;set; }
     }
}
