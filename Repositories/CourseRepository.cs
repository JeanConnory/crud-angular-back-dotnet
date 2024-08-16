using AutoMapper;
using crud_dotnet.Data;
using crud_dotnet.DTO;
using crud_dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_dotnet.Repositories;

public class CourseRepository : ICourseRepository
{
    private readonly AppDbContext _appDbContext;
    private readonly IMapper _mapper;

    public CourseRepository(AppDbContext appDbContext, IMapper mapper)
    {
        _appDbContext = appDbContext;
        _mapper = mapper;
    }

    //public async Task<IEnumerable<CourseDTO>> GetCoursesAsync()
    //{
    //    var courses = await _appDbContext.Courses
    //                                .Where(c => c.Status == Enums.Status.ATIVO)
    //                                .Include(l => l.Lessons)
    //                                .ToListAsync();

    //    return _mapper.Map<IEnumerable<CourseDTO>>(courses);
    //}

    public async Task<CourseDTO> FindByIdAsync(long id)
    {
        var course = await _appDbContext.Courses
                                    .Where(c => c.Id == id && c.Status == Enums.Status.ATIVO)
                                    .Include(l => l.Lessons)
                                    .FirstOrDefaultAsync();

        return _mapper.Map<CourseDTO>(course);
    }

    public async Task<CourseDTO> CreateAsync(CourseDTO courseDTO)
    {
        var course = _mapper.Map<Course>(courseDTO);
        _appDbContext.Add(course);
        await _appDbContext.SaveChangesAsync();
        return _mapper.Map<CourseDTO>(course);
    }

    public async Task<CourseDTO> UpdateAsync(long id, CourseDTO courseDTO)
    {
        Course course = await _appDbContext.Courses
            .Include(l => l.Lessons)
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Id == id);
        course.Lessons.Clear();
        course = _mapper.Map<Course>(courseDTO);
        _appDbContext.Update(course);
        await _appDbContext.SaveChangesAsync();
        return _mapper.Map<CourseDTO>(course);
    }

    public async Task<CourseDTO> DeleteAsync(long id)
    {
        Course course = await _appDbContext.Courses.FindAsync(id);
        _appDbContext.Remove(course);
        await _appDbContext.SaveChangesAsync();
        return _mapper.Map<CourseDTO>(course);
    }

    public async Task<PaginatedList<CourseDTO>> GetCoursesAsync(int pageIndex, int pageSize)
    {
        var courses = await _appDbContext.Courses            
            .Skip(pageIndex * pageSize)
            .Take(pageSize)
            .ToListAsync();

        var coursesDTO = _mapper.Map<List<CourseDTO>>(courses);

        var totalElements = await _appDbContext.Courses.CountAsync();
        var totalPages = (int)Math.Ceiling(totalElements / (double)pageSize);

        return new PaginatedList<CourseDTO>(coursesDTO, pageIndex, totalPages, totalElements);
    }
}
