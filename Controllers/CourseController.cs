using crud_dotnet.Models;
using crud_dotnet.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace crud_dotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;

        public CourseController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Course>> List()
        {
            return await _courseRepository.GetCoursesAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Course course)
        {
            if (course == null)
                return BadRequest("Invalid data");

            await _courseRepository.CreateAsync(course);

            return Ok(StatusCodes.Status201Created);
        }
    }
}
