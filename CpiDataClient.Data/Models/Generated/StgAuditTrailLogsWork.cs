using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class StgAuditTrailLogsWork
{
    public Guid AuditTrailLogsId { get; set; }

    public DateTimeOffset ModifiedDate { get; set; }
}
