using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class StgOrdersWork
{
    public Guid OrderBatchId { get; set; }

    public DateTimeOffset? ModifiedDate { get; set; }
}
