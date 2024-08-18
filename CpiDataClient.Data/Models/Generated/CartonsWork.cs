using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class CartonsWork
{
    public Guid CartonId { get; set; }

    public DateTimeOffset? ExitingWarehouseTime { get; set; }
}
