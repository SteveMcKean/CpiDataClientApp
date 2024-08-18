using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class BotPullDetail
{
    public int Id { get; set; }

    public string BotNumber { get; set; } = null!;

    public int PullScore { get; set; }

    public string? PullReason { get; set; }

    public DateTimeOffset PullLastUpdated { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string ModifiedBy { get; set; } = null!;

    public virtual Bot BotNumberNavigation { get; set; } = null!;
}
