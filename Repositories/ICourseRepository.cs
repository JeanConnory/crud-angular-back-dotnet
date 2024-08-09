using crud_dotnet.DTO;
using crud_dotnet.Models;

namespace crud_dotnet.Repositories;

public interface ICourseRepository
{
    Task<IEnumerable<CourseDTO>> GetCoursesAsync();

    Task<CourseDTO> FindByIdAsync(long id);

    Task<CourseDTO> CreateAsync(CourseDTO course);

    Task<CourseDTO> UpdateAsync(CourseDTO course);

    Task<CourseDTO> DeleteAsync(long id);
}
