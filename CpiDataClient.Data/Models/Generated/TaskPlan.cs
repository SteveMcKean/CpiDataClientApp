using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class TaskPlan
{
    public Guid Id { get; set; }

    public int CaseGroupNumber { get; set; }

    public string? CustomerCartonGroupRef { get; set; }

    public DateTimeOffset LoadTime { get; set; }

    public DateTimeOffset? UnloadTime { get; set; }

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

    public Guid BotId { get; set; }

    public Guid LevelId { get; set; }

    public Guid? LoadTransferBufferId { get; set; }

    public Guid? LoadShelfId { get; set; }

    public int? LoadShelfLocationOffsetX { get; set; }

    public int? LoadShelfLocationOffsetY { get; set; }

    public int? LoadShelfLocationCartonOffsetX { get; set; }

    public int? LoadShelfLocationCartonOffsetY { get; set; }

    public int? LoadShelfLocationWidth { get; set; }

    public Guid? UnloadTransferBufferId { get; set; }

    public Guid? UnloadShelfId { get; set; }

    public int? UnloadShelfLocationOffsetX { get; set; }

    public int? UnloadShelfLocationOffsetY { get; set; }

    public int? UnloadShelfLocationCartonOffsetX { get; set; }

    public int? UnloadShelfLocationCartonOffsetY { get; set; }

    public int? UnloadShelfLocationWidth { get; set; }

    public bool? IsSuspect { get; set; }

    public long? LoadTaskNumber { get; set; }

    public long? UnloadTaskNumber { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual Bot Bot { get; set; } = null!;

    public virtual Level1 Level { get; set; } = null!;

    public virtual Shelf1? LoadShelf { get; set; }

    public virtual TransferBuffer1? LoadTransferBuffer { get; set; }

    public virtual ICollection<TaskPlanCarton> TaskPlanCartons { get; set; } = new List<TaskPlanCarton>();

    public virtual Shelf1? UnloadShelf { get; set; }

    public virtual TransferBuffer1? UnloadTransferBuffer { get; set; }
}
