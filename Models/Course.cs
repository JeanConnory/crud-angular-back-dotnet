using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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
    public string Category { get; set; } = string.Empty;

    [Required]
    [StringLength(10)]
    public string Status { get; set; } = "Ativo";
}
