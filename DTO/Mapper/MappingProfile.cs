using AutoMapper;
using crud_dotnet.Models;

namespace crud_dotnet.DTO.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Course, CourseDTO>().ReverseMap();
        CreateMap<Lesson, LessonDTO>().ReverseMap();
    }
}
