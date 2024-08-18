using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class BreakpackLoop
{
    public int Id { get; set; }

    public int LevelMapModelId { get; set; }

    public string Name { get; set; } = null!;

    public string CellName { get; set; } = null!;

    public string CellSide { get; set; } = null!;

    public int Length { get; set; }

    public int Width { get; set; }

    public int OriginPointX { get; set; }

    public int OriginPointY { get; set; }

    public int TransitAisleNumber { get; set; }

    public int InteractionAisleNumber { get; set; }

    public string TurnAroundDeckName { get; set; } = null!;

    public int TurnAroundDeckId { get; set; }
}
