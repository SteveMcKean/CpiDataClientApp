using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class AuditTrailLogsWork
{
    public Guid AuditTrailLogsId { get; set; }

    public DateTimeOffset ModifiedDate { get; set; }
}
