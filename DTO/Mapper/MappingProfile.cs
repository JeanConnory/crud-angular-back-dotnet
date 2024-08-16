using AutoMapper;
using crud_dotnet.Models;

namespace crud_dotnet.DTO.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Course, CourseDTO>()
            .ForMember(dest => dest.Lessons, opt => opt.MapFrom(src => src.Lessons))
            .ReverseMap();

        CreateMap<Lesson, LessonDTO>().ReverseMap();
    }
}
