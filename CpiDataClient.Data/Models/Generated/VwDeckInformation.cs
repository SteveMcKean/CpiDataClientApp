using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwDeckInformation
{
    public int DeckType { get; set; }

    public int? BoundaryId { get; set; }

    public string? Name { get; set; }

    public int MinX { get; set; }

    public int? MaxX { get; set; }

    public int MinY { get; set; }

    public int? MaxY { get; set; }

    public string? ResourceName { get; set; }

    public Guid LevelId { get; set; }
}
