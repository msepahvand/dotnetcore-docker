using Microsoft.EntityFrameworkCore;
using System;

namespace StudentAPI.Core.Models
{
    public class DataContext : DbContext
    {
        private static string ConnectionString
        {
            get
            {
                var server = Environment.GetEnvironmentVariable("DatabaseServer") ?? "localhost\\SQLEXPRESS";
                var database = Environment.GetEnvironmentVariable("DatabaseName") ?? "DotnetCoreDockerDb";
                var user = Environment.GetEnvironmentVariable("DatabaseUser") ?? "sa";
                var password = Environment.GetEnvironmentVariable("DatabaseUserPassword") ?? "password";
                return $"Server={server};Database={database};User={user};Password={password};MultipleActiveResultSets=true";
            }
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DataContext()
        {
            if(this.Database != null)
            {
                this.Database.EnsureCreated();
            }
        }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasKey(x => x.Id);
            modelBuilder.Entity<Student>().Property(x => x.GivenName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Student>().Property(x => x.FamilyName).IsRequired().HasMaxLength(50);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        { 
            builder.UseSqlServer(ConnectionString);
            base.OnConfiguring(builder);
        }
    }
}