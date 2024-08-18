using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class StartupScriptsLog
{
    public int Id { get; set; }

    public string StartupSpname { get; set; } = null!;

    public string Action { get; set; } = null!;

    public DateTimeOffset ExecutionDate { get; set; }

    public string ExecutedBy { get; set; } = null!;

    public int RowsAffected { get; set; }

    public int? ExecutionStatus { get; set; }

    public Guid? SessionKey { get; set; }

    public int? StoredProcedureId { get; set; }
}
