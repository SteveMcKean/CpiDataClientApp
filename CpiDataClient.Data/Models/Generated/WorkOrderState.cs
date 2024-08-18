using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class WorkOrderState
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<WorkOrderChangeState> WorkOrderChangeStateNewStateNavigations { get; set; } = new List<WorkOrderChangeState>();

    public virtual ICollection<WorkOrderChangeState> WorkOrderChangeStateOldStateNavigations { get; set; } = new List<WorkOrderChangeState>();
}
