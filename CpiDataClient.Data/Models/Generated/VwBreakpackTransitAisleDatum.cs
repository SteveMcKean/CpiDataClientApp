using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwBreakpackTransitAisleDatum
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public Guid AisleId { get; set; }

    public int Number { get; set; }

    public int LowerLeftCornerX { get; set; }

    public int LowerLeftCornerY { get; set; }

    public int UpperRightCornerY { get; set; }

    public int UpperRightCornerX { get; set; }
}
