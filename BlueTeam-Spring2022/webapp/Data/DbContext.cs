#nullable disable
using WebApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApp1.Data
{
    public class webappContext : DbContext
    {
        public webappContext(DbContextOptions<webappContext> options) : base(options)
        {

        }

        public DbSet<Course> Courses {get; set;}
        public DbSet<Instructor> Instructors {get; set;}
        public DbSet<Form> Forms {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Instructor>().ToTable("Instructor");
            modelBuilder.Entity<Form>().ToTable("Form");
        }
    }
}