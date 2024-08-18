using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ExecutionDetailsLog
{
    public int Id { get; set; }

    public int ExecutionId { get; set; }

    public string ObjectName { get; set; } = null!;

    public string? TableName { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public int? TotalTimeInMs { get; set; }

    public int RecordsAffected { get; set; }

    public string? ErrorMessage { get; set; }

    public virtual ExecutionLog Execution { get; set; } = null!;
}
