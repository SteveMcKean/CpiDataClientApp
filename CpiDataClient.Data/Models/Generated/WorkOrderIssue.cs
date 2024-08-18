using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class WorkOrderIssue
{
    public Guid Id { get; set; }

    public Guid IssueId { get; set; }

    public Guid WorkOrderId { get; set; }

    public DateTimeOffset CreatedTime { get; set; }

    public string CreatedUser { get; set; } = null!;

    public DateTimeOffset ModifiedTime { get; set; }

    public string ModifiedUser { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual Issue Issue { get; set; } = null!;

    public virtual WorkOrder WorkOrder { get; set; } = null!;

    public virtual ICollection<WorkOrderIssueResolution> WorkOrderIssueResolutions { get; set; } = new List<WorkOrderIssueResolution>();
}
