using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwAisleSideWithShelvesInfo
{
    public Guid Id { get; set; }

    public int LevelNumber { get; set; }

    public int AisleNumber { get; set; }

    public string? AisleSideName { get; set; }

    public string AisleSide { get; set; } = null!;

    public string? ShelfName { get; set; }
}
