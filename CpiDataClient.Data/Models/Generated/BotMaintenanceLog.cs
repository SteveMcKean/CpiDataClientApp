using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class BotMaintenanceLog
{
    public int Id { get; set; }

    public string BotNumber { get; set; } = null!;

    public string? OperatorComment { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual Bot BotNumberNavigation { get; set; } = null!;
}
