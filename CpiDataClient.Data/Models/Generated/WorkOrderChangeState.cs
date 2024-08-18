using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class WorkOrderChangeState
{
    public Guid Id { get; set; }

    public Guid WorkOrderId { get; set; }

    public int NewState { get; set; }

    public int OldState { get; set; }

    public DateTimeOffset StateTime { get; set; }

    public string UserName { get; set; } = null!;

    public bool IsCurrent { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual WorkOrderState NewStateNavigation { get; set; } = null!;

    public virtual WorkOrderState OldStateNavigation { get; set; } = null!;

    public virtual WorkOrder WorkOrder { get; set; } = null!;
}
