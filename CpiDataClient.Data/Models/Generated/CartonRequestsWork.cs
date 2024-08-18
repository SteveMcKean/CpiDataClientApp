using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class CartonRequestsWork
{
    public Guid CartonRequestId { get; set; }

    public DateTimeOffset ModifiedDate { get; set; }
}
