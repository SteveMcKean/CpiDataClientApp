using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OutputPriority
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<CustomerPriorityRule> CustomerPriorityRules { get; set; } = new List<CustomerPriorityRule>();
}
