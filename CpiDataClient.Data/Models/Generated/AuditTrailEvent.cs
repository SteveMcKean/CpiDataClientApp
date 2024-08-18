using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class AuditTrailEvent
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<AuditTrailLog> AuditTrailLogs { get; set; } = new List<AuditTrailLog>();
}
