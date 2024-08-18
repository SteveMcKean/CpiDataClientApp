using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Inventory
{
    public Guid Id { get; set; }

    public int CaseGroupNumber { get; set; }

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

    public DateTimeOffset? LastScanTime { get; set; }

    public DateTimeOffset OnShelfTime { get; set; }

    public DateTimeOffset? OffShelfTime { get; set; }

    public Guid? CartonId { get; set; }

    public Guid? ShelfId { get; set; }

    public long? LoadTaskNumber { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public bool? IsSuspect { get; set; }

    public virtual Carton? Carton { get; set; }

    public virtual ProductType ItemType1 { get; set; } = null!;

    public virtual InventoryItemType ItemTypeNavigation { get; set; } = null!;

    public virtual Shelf1? Shelf { get; set; }
}
