using System.ComponentModel.DataAnnotations;

namespace crud_dotnet.DTO
{
    public class LessonDTO
    {
        public long? Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(11)]
        public string YoutubeUrl { get; set; }

        //[ForeignKey("Course")]
        public long CourseId { get; set; }
    }
}
