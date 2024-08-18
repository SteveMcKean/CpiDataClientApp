using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OrderBatch
{
    public Guid Id { get; set; }

    public string CustomerBatchRef { get; set; } = null!;

    public int State { get; set; }

    public int WaveNumber { get; set; }

    public int? NonSymboticHeavyCaseCount { get; set; }

    public int? NonSymboticLightCaseCount { get; set; }

    public int? Priority { get; set; }

    public DateTimeOffset? ClosedTime { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual OrderBatchState StateNavigation { get; set; } = null!;
}
