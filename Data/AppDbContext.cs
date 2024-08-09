using crud_dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_dotnet.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Course> Courses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Lesson>().HasData
         (
             new Lesson
             {
                 Id = 1,
                 Name = "Teste",
                 YoutubeUrl = "teste.html",
                 CourseId = 1
             },
             new Lesson
             {
                 Id = 2,
                 Name = "Teste 2",
                 YoutubeUrl = "teste2.html",
                 CourseId = 1
             },
             new Lesson
             {
                 Id = 3,
                 Name = "Teste 3",
                 YoutubeUrl = "teste3.html",
                 CourseId = 2
             }
         );

        modelBuilder.Entity<Course>().HasData
            (
                new Course
                {
                    Id = 1,
                    Name = "Angular",
                    Category = Enums.Category.FRONTEND                    
                },
                new Course
                {
                    Id = 2,
                    Name = "React",
                    Category = Enums.Category.FRONTEND
                },
                new Course
                {
                    Id = 3,
                    Name = "VueJS",
                    Category = Enums.Category.FRONTEND
                },
                new Course
                {
                    Id = 4,
                    Name = "Blazor",
                    Category = Enums.Category.FRONTEND
                },
                new Course
                {
                    Id = 5,
                    Name = "Java",
                    Category = Enums.Category.BACKEND
                },
                new Course
                {
                    Id = 6,
                    Name = "DotNet",
                    Category = Enums.Category.BACKEND
                },
                new Course
                {
                    Id = 7,
                    Name = "React Native",
                    Category = Enums.Category.MOBILE
                },
                new Course
                {
                    Id = 8,
                    Name = "Flutter",
                    Category = Enums.Category.MOBILE
                },
                new Course
                {
                    Id = 9,
                    Name = "DotNet MAUI",
                    Category = Enums.Category.MOBILE
                }
            );

       
    }
}
