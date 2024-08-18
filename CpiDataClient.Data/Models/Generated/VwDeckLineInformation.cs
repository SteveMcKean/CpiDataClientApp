using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwDeckLineInformation
{
    public int Type { get; set; }

    public Guid? LevelId { get; set; }

    public Guid? DrivewayId { get; set; }

    public Guid? AisleId { get; set; }

    public string Name { get; set; } = null!;

    public int Length { get; set; }

    public int Width { get; set; }

    public int Orientation { get; set; }

    public int OriginX { get; set; }

    public int OriginY { get; set; }

    public Guid DeckId { get; set; }

    public int? DeckLineId { get; set; }

    public string? ResourceName { get; set; }
}
