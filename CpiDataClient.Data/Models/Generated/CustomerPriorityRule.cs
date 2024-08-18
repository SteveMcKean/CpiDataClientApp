using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class CustomerPriorityRule
{
    public int Id { get; set; }

    public string CustomerNumber { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public int FreshnessWindow { get; set; }

    public bool StrictFreshness { get; set; }

    public int OutputPriority { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual OutputPriority OutputPriorityNavigation { get; set; } = null!;
}
