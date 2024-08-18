using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwInventoryLocationInformation
{
    public Guid? Id { get; set; }

    public int ModuleNumber { get; set; }

    public int ZoneNumber { get; set; }

    public int AisleNumber { get; set; }

    public int BayNumber { get; set; }

    public int ShelfNumber { get; set; }

    public int CaseGroupNumber { get; set; }

    public int? ShelfLocationOffsetX { get; set; }

    public int? ShelfLocationOffsetY { get; set; }

    public int ShelfSide { get; set; }

    public int LevelNumber { get; set; }

    public string? BayName { get; set; }

    public int? SuspectType { get; set; }

    public int? SuspectReason { get; set; }

    public int? SuspectAction { get; set; }

    public DateTimeOffset? LastScanTime { get; set; }

    public string? ShelfName { get; set; }

    public int ShelfWidth { get; set; }

    public Guid BayId { get; set; }

    public Guid? ShelfId { get; set; }

    public int? CartonCount { get; set; }

    public int? SuspectResolution { get; set; }

    public int? SuspectReportedBy { get; set; }

    public int? SuspectLocationSubState { get; set; }

    public int ShelfOffsetX { get; set; }

    public int ShelfOffsetY { get; set; }

    public int? ShelfLocationWidth { get; set; }

    public bool? IsSuspect { get; set; }
}
