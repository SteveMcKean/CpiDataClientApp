using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwBreakpackLoopInformation1
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string CellName { get; set; } = null!;

    public string CellSide { get; set; } = null!;

    public string? BreakpackInteractionAisleName { get; set; }

    public string? BreakpackTransitAisleName { get; set; }

    public int LowerLeftCornerX { get; set; }

    public int LowerLeftCornerY { get; set; }

    public int? UpperRightCornerY { get; set; }

    public int? UpperRightCornerX { get; set; }
}
