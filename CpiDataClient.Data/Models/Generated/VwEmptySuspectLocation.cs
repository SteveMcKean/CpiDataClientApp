using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwEmptySuspectLocation
{
    public Guid InventoryId { get; set; }

    public Guid? CartonId { get; set; }

    public int CaseGroupNumber { get; set; }

    public string? CustomerCartonGroupRef { get; set; }

    public int ItemType { get; set; }

    public int? SuspectType { get; set; }

    public int? SuspectReportedBy { get; set; }

    public DateTimeOffset? SuspectTime { get; set; }

    public DateTimeOffset? SuspectClearTime { get; set; }

    public int? SuspectReason { get; set; }

    public int? SuspectResolution { get; set; }

    public int? PickDepth { get; set; }

    public int? SuspectAction { get; set; }

    public int? SuspectLocationSubState { get; set; }

    public DateTimeOffset OnShelfTime { get; set; }

    public DateTimeOffset? OffShelfTime { get; set; }

    public int? ShelfLocationOffsetX { get; set; }

    public int? ShelfLocationOffsetY { get; set; }

    public int? ShelfLocationCartonOffsetX { get; set; }

    public int? ShelfLocationCartonOffsetY { get; set; }

    public int? ShelfLocationWidth { get; set; }

    public Guid? ShelfId { get; set; }

    public bool? IsSuspect { get; set; }

    public Guid ZoneId { get; set; }

    public int ZoneNumber { get; set; }

    public int LevelNumber { get; set; }

    public Guid LevelId { get; set; }

    public Guid AisleId { get; set; }

    public int AisleNumber { get; set; }

    public Guid BayId { get; set; }

    public int BayNumber { get; set; }

    public int ShelfNumber { get; set; }

    public int ShelfSide { get; set; }

    public int OffsetX { get; set; }

    public int OffsetY { get; set; }

    public int OffsetZ { get; set; }

    public int ShelfWidth { get; set; }

    public int ShelfLength { get; set; }

    public int ShelfHeight { get; set; }

    public int ShelfWeight { get; set; }

    public int LevelHeight { get; set; }
}
