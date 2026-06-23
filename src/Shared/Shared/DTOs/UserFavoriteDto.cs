using System;

namespace Shared.DTOs;

public class UserFavoriteDto
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid BookId { get; set; }
    public DateTime CreatedAt { get; set; }
}
