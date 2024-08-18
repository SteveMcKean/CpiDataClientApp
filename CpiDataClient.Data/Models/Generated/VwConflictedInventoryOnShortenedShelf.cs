using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwConflictedInventoryOnShortenedShelf
{
    public Guid Id { get; set; }

    public Guid ShelfId { get; set; }

    public string? Name { get; set; }
}
