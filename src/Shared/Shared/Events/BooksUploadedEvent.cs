using System;
using System.Collections.Generic;

namespace Shared.Events;

public class BooksUploadedEvent
{
    public List<BookUploadedItem> Books { get; set; } = new();
}

