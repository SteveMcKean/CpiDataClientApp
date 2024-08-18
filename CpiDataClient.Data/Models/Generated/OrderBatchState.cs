using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OrderBatchState
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<OrderBatch> OrderBatches { get; set; } = new List<OrderBatch>();
}
