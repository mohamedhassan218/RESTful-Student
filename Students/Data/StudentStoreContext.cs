using Microsoft.EntityFrameworkCore;
using Students.Entities;

namespace Students.Data;

public class StudentStoreContext(DbContextOptions<StudentStoreContext> options)
    : DbContext(options)
{
    public DbSet<Student> Students => Set<Student>();

    public DbSet<Department> Departments => Set<Department>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>().HasData(
            new
            {
                Id = 1,
                Name = "Computer Science"
            }, new
            {
                Id = 2,
                Name = "Information Technology"
            }, new
            {
                Id = 3,
                Name = "Information System"
            }, new
            {
                Id = 4,
                Name = "Multi Media"
            }, new
            {
                Id = 5,
                Name = "Software Engineering"
            }, new
            {
                Id = 6,
                Name = "Bio Information"
            }
        );
    }

}