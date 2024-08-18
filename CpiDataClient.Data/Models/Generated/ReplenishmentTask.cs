using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ReplenishmentTask
{
    public int Id { get; set; }

    public string Plant { get; set; } = null!;

    public Guid? ReplenishmentRequestId { get; set; }

    public string? Location { get; set; }

    public Guid SkuId { get; set; }

    public string? OperatorName { get; set; }

    public DateTime? TimeRequestLastAssigned { get; set; }

    public int TaskPriority { get; set; }

    public int AssignedCount { get; set; }

    public int TaskState { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public DateTime? Deadline { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public Guid? OutboundPalletId { get; set; }

    public virtual OutboundPallet? OutboundPallet { get; set; }

    public virtual ReplenishmentPriority TaskPriorityNavigation { get; set; } = null!;

    public virtual ReplenishmentTaskState TaskStateNavigation { get; set; } = null!;
}
