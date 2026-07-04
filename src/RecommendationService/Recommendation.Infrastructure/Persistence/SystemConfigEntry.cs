using System.ComponentModel.DataAnnotations;

namespace Recommendation.Infrastructure.Persistence;

public class SystemConfigEntry
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(256)]
    public string Key { get; set; } = string.Empty;

    [MaxLength(1024)]
    public string Value { get; set; } = string.Empty;
}
