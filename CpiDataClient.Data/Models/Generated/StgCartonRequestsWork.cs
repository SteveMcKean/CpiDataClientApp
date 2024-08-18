using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class StgCartonRequestsWork
{
    public Guid CartonRequestId { get; set; }

    public DateTimeOffset ModifiedDate { get; set; }
}
