using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ExecutionLog
{
    public int ExecutionId { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? ErrorMessage { get; set; }

    public virtual ICollection<ExecutionDetailsLog> ExecutionDetailsLogs { get; set; } = new List<ExecutionDetailsLog>();
}
