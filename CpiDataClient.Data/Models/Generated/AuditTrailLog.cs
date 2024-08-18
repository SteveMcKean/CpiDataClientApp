using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class AuditTrailLog
{
    public Guid Id { get; set; }

    public int AuditTrailGroup { get; set; }

    public int AuditTrailEvent { get; set; }

    public int AuditTrailReason { get; set; }

    public DateTimeOffset EventTime { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public string? Detail { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual AuditTrailEvent AuditTrailEventNavigation { get; set; } = null!;

    public virtual AuditTrailGroup AuditTrailGroupNavigation { get; set; } = null!;

    public virtual AuditTrailReason AuditTrailReasonNavigation { get; set; } = null!;
}
