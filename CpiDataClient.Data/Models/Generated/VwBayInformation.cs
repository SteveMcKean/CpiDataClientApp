using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwBayInformation
{
    public int LevelNumber { get; set; }

    public string? Name { get; set; }

    public string? BayName { get; set; }

    public int BayNumber { get; set; }

    public int BaySide { get; set; }

    public int AisleNumber { get; set; }

    public int? Height { get; set; }

    public int? Width { get; set; }

    public int? Length { get; set; }

    public int? OffsetX { get; set; }

    public int? OffsetY { get; set; }

    public Guid LevelId { get; set; }

    public Guid AisleId { get; set; }

    public int LevelMapModelNumber { get; set; }

    public string? ResourceName { get; set; }
}
