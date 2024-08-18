using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class WorkOrderNote
{
    public Guid Id { get; set; }

    public string Note { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public DateTimeOffset CreatedTime { get; set; }

    public Guid WorkOrderId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual WorkOrder WorkOrder { get; set; } = null!;
}
