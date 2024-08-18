using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class AuditTrailReason
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<AuditTrailLog> AuditTrailLogs { get; set; } = new List<AuditTrailLog>();
}
