using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwBotPullItem
{
    public Guid? Id { get; set; }

    public string BotNumber { get; set; } = null!;

    public int PullScore { get; set; }

    public string? Pullreason { get; set; }

    public DateTimeOffset PullLastUpdated { get; set; }

    public string Location { get; set; } = null!;

    public DateTimeOffset? LastMaintenance { get; set; }

    public string? OperatorComment { get; set; }
}
