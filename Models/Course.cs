using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace crud_dotnet.Models;

public class Course
{
    [Key]
    [JsonPropertyName("_id")]
    public long Id { get; set; }

    [Required]
    [StringLength(200)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [StringLength(200)]
    public string Category { get; set; } = string.Empty;
}
