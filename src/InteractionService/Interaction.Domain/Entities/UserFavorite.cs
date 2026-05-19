using System;

namespace Interaction.Domain.Entities;

public class UserFavorite
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid UserId { get; set; }
    public Guid BookId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
