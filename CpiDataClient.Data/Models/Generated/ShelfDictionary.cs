using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ShelfDictionary
{
    public Guid ShelfId { get; set; }

    public string? HashString { get; set; }
}
