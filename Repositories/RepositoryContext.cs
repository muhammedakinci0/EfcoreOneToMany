using Microsoft.EntityFrameworkCore;
using phones.Models;
using students.Models;
using students.Repositories.Config;

namespace students.Repositories
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Phone> Phones { get; set; }
     
     

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfig());
        }
    }
}
