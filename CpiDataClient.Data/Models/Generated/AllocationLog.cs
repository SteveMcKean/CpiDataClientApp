using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class AllocationLog
{
    public int AllocationLogSk { get; set; }

    public Guid OrderId { get; set; }

    public DateTimeOffset StartTime { get; set; }

    public DateTimeOffset EndTime { get; set; }

    public int CartonRequestCount { get; set; }

    public int InventoryCount { get; set; }
}
