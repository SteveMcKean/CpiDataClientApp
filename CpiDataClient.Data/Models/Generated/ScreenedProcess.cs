using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ScreenedProcess
{
    public int ScreenedProcessSk { get; set; }

    public int SessionId { get; set; }

    public string? ProgramName { get; set; }

    public string? HostName { get; set; }

    public string? LoginName { get; set; }

    public long TransactionId { get; set; }

    public DateTime TransactionBeginTime { get; set; }

    public string? Dbname { get; set; }

    public string? QueryText { get; set; }

    public string? RequestText { get; set; }

    public bool IsTerminated { get; set; }

    public DateTime ExecutionDateTime { get; set; }
}
