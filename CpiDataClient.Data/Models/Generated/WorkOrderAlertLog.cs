using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class WorkOrderAlertLog
{
    public Guid Id { get; set; }

    public Guid AlertLogId { get; set; }

    public Guid WorkOrderId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual AlertLog AlertLog { get; set; } = null!;

    public virtual WorkOrder WorkOrder { get; set; } = null!;
}
