using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Application.DTOs;
public class BookItemDTO
{
    public Guid BookId { get; set; } 
    public string Text { get; set; } = string.Empty;

}
