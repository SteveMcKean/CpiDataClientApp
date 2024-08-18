using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ResetShelfDetailLog
{
    public int Id { get; set; }

    public int ResetShelfLogId { get; set; }

    public string Action { get; set; } = null!;

    public Guid InventoryId { get; set; }

    public Guid? CartonId { get; set; }

    public int? CaseGroupNumber { get; set; }

    public string? CustomerCartonGroupRef { get; set; }

    public int? ShelfLocationOffsetX { get; set; }

    public int? ShelfLocationOffsetY { get; set; }

    public int? ShelfLocationCartonOffsetX { get; set; }

    public int? ShelfLocationCartonOffsetY { get; set; }

    public int? ShelfLocationWidth { get; set; }

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

    public bool? IsSuspect { get; set; }
}
