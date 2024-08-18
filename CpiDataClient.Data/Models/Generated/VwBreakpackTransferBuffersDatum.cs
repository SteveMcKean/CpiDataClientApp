using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwBreakpackTransferBuffersDatum
{
    public string? Name { get; set; }

    public Guid Id { get; set; }

    public int? SlotId { get; set; }

    public int? MaxCartonHeightmm { get; set; }

    public int GlobalXmm { get; set; }

    public int GlobalYmm { get; set; }

    public int? BotTransferHeight { get; set; }

    public int? LowerLeftCornerX { get; set; }

    public int? LowerLeftCornerY { get; set; }

    public int? UpperRightCornerX { get; set; }

    public int? UpperRightCornerY { get; set; }
}
