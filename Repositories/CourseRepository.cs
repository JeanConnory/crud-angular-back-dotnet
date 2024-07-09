using crud_dotnet.Data;
using crud_dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_dotnet.Repositories;

public class CourseRepository : ICourseRepository
{
    private readonly AppDbContext _appDbContext;

    public CourseRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<IEnumerable<Course>> GetCoursesAsync()
    {
        return await _appDbContext.Courses.ToListAsync();
    }

    public async Task<Course> CreateAsync(Course course)
    {
        _appDbContext.Add(course);
        await _appDbContext.SaveChangesAsync();
        return course;
    }    
}
