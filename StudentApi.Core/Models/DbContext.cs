using Microsoft.EntityFrameworkCore;

namespace StudentApi.Core.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DataContext()
        {
            
        }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(x=>x.Id);
            modelBuilder.Entity<Student>().Property(x => x.GivenName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Student>().Property(x => x.FamilyName).IsRequired().HasMaxLength(50);
        }
    }
}