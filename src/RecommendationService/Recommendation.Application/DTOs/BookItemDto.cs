using System;
using System.Collections.Generic;
using System.Text;

namespace Recommendation.Application.DTOs;
public class BookItemDTO
{
    public Guid BookId { get; set; } 
    public string Text { get; set; } = string.Empty;

}
