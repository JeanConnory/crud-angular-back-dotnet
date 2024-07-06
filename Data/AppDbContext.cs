using crud_dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_dotnet.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Course> Courses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Course>().HasData
            (
                new Course
                {
                    Id = 1,
                    Name = "Angular",
                    Category = "Front-End"
                },
                new Course
                {
                    Id = 2,
                    Name = "React",
                    Category = "Front-End"
                },
                new Course
                {
                    Id = 3,
                    Name = "VueJS",
                    Category = "Front-End"
                },
                new Course
                {
                    Id = 4,
                    Name = "NextJS",
                    Category = "Front-End"
                },
                new Course
                {
                    Id = 5,
                    Name = "Blazor",
                    Category = "Front-End"
                },
                new Course
                {
                    Id = 6,
                    Name = "Java",
                    Category = "Back-End"
                },
                new Course
                {
                    Id = 7,
                    Name = "DotNet",
                    Category = "Back-End"
                },
                new Course
                {
                    Id = 8,
                    Name = "PHP",
                    Category = "Back-End"
                },
                new Course
                {
                    Id = 9,
                    Name = "Ruby",
                    Category = "Back-End"
                },
                new Course
                {
                    Id = 10,
                    Name = "Python",
                    Category = "Back-End"
                },
                new Course
                {
                    Id = 11,
                    Name = "NodeJS",
                    Category = "Back-End"
                },
                new Course
                {
                    Id = 12,
                    Name = "NestJS",
                    Category = "Back-End"
                },
                new Course
                {
                    Id = 13,
                    Name = "Kotlin",
                    Category = "Mobile"
                },
                new Course
                {
                    Id = 14,
                    Name = "Swift",
                    Category = "Mobile"
                },
                new Course
                {
                    Id = 15,
                    Name = "React Native",
                    Category = "Mobile"
                },
                new Course
                {
                    Id = 16,
                    Name = "Flutter",
                    Category = "Mobile"
                },
                new Course
                {
                    Id = 17,
                    Name = "DotNet MAUI",
                    Category = "Mobile"
                }
            );
    }
}
