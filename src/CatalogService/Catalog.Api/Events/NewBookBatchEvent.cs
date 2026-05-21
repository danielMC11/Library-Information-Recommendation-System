using System;
using System.Collections.Generic;
using System.Text;
using Recommendation.Application.DTOs;

namespace Recommendation.Application.Events;
public class NewBookBatchEvent
{

    public List<BookItemDTO> Books { get; set; } = new List<BookItemDTO>();

}

