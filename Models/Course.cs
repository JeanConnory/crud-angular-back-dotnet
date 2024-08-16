using crud_dotnet.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace crud_dotnet.Models;

public class Course
{
    [Key]
    //[JsonPropertyName("_id")]
    [JsonProperty(PropertyName = "_id")]
    public long? Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [StringLength(10)]
    public Category Category { get; set; }

    [Required]
    [StringLength(10)]
    public Status Status { get; set; }

    public List<Lesson> Lessons { get; set; }
}
