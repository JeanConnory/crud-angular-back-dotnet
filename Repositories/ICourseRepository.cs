using crud_dotnet.Models;

namespace crud_dotnet.Repositories;

public interface ICourseRepository
{
    Task<IEnumerable<Course>> GetCoursesAsync();

    Task<Course> CreateAsync(Course course);
}
