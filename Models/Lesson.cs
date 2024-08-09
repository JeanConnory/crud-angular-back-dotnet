using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace crud_dotnet.Models;

public class Lesson
{
    [Key]
    public long Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [Required]
    [StringLength(11)]
    public string YoutubeUrl { get; set; }

    //[ForeignKey("Course")]
    public long CourseId { get; set; }    
    //public virtual Course Course { get; set; }
}
