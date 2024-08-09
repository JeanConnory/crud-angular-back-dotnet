using crud_dotnet.Enums;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace crud_dotnet.DTO
{
    public class CourseDTO
    {
        [JsonProperty(PropertyName = "_id")]
        public long? Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public Category Category { get; set; }

        public List<LessonDTO> Lessons { get; set; }
    }
}
