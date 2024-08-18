using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class StgAlertLogsWork
{
    public Guid AlertLogId { get; set; }

    public DateTimeOffset? ModifiedDate { get; set; }
}
