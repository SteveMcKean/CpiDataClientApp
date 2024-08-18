using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ReallocatedCartonRequest
{
    public int RecordNumber { get; set; }

    public Guid ReallocatedCartonRequestsId { get; set; }

    public DateTimeOffset ReallocationDateTime { get; set; }
}
