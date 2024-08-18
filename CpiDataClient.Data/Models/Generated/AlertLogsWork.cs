using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class AlertLogsWork
{
    public Guid AlertLogId { get; set; }

    public DateTimeOffset? ModifiedDate { get; set; }
}
