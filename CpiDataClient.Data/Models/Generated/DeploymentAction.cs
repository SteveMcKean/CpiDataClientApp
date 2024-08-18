using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class DeploymentAction
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<ProcessLog> ProcessLogs { get; set; } = new List<ProcessLog>();
}
