using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class LiftLoadsTombstone
{
    public int TransferBufferLoadsTombstoneSk { get; set; }

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

    public Guid TransferBufferId { get; set; }

    public long? LoadTaskNumber { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime TombstoneDate { get; set; }
}
