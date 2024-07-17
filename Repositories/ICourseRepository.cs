using crud_dotnet.Models;

namespace crud_dotnet.Repositories;

public interface ICourseRepository
{
    Task<IEnumerable<Course>> GetCoursesAsync();

    Task<Course> FindByIdAsync(long id);

    Task<Course> CreateAsync(Course course);

    Task<Course> UpdateAsync(Course course);
}
