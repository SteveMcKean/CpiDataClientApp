using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class CleanupOrdersBackup
{
    public Guid OrderId { get; set; }

    public int OldState { get; set; }

    public int NewState { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTimeOffset UpdatedOn { get; set; }
}
