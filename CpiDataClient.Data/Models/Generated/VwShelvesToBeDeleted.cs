using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwShelvesToBeDeleted
{
    public Guid ShelfId { get; set; }

    public string? ShelfName { get; set; }
}
