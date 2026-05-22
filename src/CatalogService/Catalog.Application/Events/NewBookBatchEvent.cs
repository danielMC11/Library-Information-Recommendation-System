using System;
using System.Collections.Generic;
using System.Text;
using Catalog.Application.DTOs;

namespace Catalog.Application.Events;
public class NewBookBatchEvent
{

    public List<BookItemDTO> Books { get; set; } = new List<BookItemDTO>();

}

