using crud_dotnet.DTO;
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
        public async Task<IEnumerable<CourseDTO>> List()
        {
            return await _courseRepository.GetCoursesAsync();
        }

        [HttpGet("{id}")]
        public async Task<CourseDTO> GetById(long id)
        {
            return await _courseRepository.FindByIdAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CourseDTO course)
        {
            if (course == null)
                return BadRequest("Invalid data");

            await _courseRepository.CreateAsync(course);

            return Ok(course);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(long id, [FromBody] CourseDTO course)
        {
            if (id != course.Id)
                return BadRequest();

            if (course == null)
                return BadRequest("Invalid data");

            await _courseRepository.UpdateAsync(course);
            return Ok(course);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var course = await _courseRepository.FindByIdAsync(id);

            if (course == null)
                return NotFound("Course not found");

            //course.Status = "Inativo";

            await _courseRepository.DeleteAsync(id);

            return NoContent();
        }
    }
}
