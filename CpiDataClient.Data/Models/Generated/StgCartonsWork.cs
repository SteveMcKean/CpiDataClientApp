using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class StgCartonsWork
{
    public Guid CartonId { get; set; }

    public DateTimeOffset? ExitingWarehouseTime { get; set; }
}
