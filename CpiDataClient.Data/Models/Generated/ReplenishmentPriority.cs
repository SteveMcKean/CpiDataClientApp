using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ReplenishmentPriority
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<ReplenishmentTask> ReplenishmentTasks { get; set; } = new List<ReplenishmentTask>();
}
