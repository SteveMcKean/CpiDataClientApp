using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwBreakpackLoopInformation
{
    public Guid LevelId { get; set; }

    public string? Name { get; set; }

    public string CellName { get; set; } = null!;

    public int CellSideId { get; set; }

    public int Length { get; set; }

    public int Width { get; set; }

    public int OriginPointX { get; set; }

    public int OriginPointY { get; set; }

    public int TransitAisleNumber { get; set; }

    public int InteractionAisleNumber { get; set; }

    public Guid TransitAisleId { get; set; }

    public Guid InteractionAisleId { get; set; }

    public string? TurnAroundDeckName { get; set; }

    public int TurnAroundDeckId { get; set; }
}
