using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OrdersWork
{
    /// <summary>
    /// The IDs in here are actually from Orders.OrderBatches.OrderBatchID.
    /// </summary>
    public Guid OrderBatchId { get; set; }

    public DateTimeOffset? ModifiedDate { get; set; }
}
