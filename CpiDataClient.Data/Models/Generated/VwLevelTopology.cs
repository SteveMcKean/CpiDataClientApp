using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwLevelTopology
{
    public Guid? Id { get; set; }

    public Guid? ParentId { get; set; }

    public string? ParentName { get; set; }

    public int? ParentNumber { get; set; }

    public string CompType { get; set; } = null!;

    public Guid? CompId { get; set; }

    public string? CompName { get; set; }

    public int? CompNumber { get; set; }

    public int? LowerLeftCornerX { get; set; }

    public int LowerLeftCornerY { get; set; }

    public int? UpperRightCornerX { get; set; }

    public int? UpperRightCornerY { get; set; }

    public int MaxCartonHeightmm { get; set; }

    public int MaxStorageWeight { get; set; }

    public int BotTransferHeight { get; set; }

    public string ResourceSubType { get; set; } = null!;

    public int Orientation { get; set; }
}
