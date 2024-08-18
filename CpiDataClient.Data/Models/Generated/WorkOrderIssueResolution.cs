using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class WorkOrderIssueResolution
{
    public Guid Id { get; set; }

    public Guid ResolutionId { get; set; }

    public Guid WorkOrderIssueId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual WorkOrderIssue WorkOrderIssue { get; set; } = null!;
}
