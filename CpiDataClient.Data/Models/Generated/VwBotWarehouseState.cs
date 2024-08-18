using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwBotWarehouseState
{
    public Guid Id { get; set; }

    public DateTimeOffset FromDate { get; set; }

    public DateTimeOffset? ToDate { get; set; }

    public int Location { get; set; }

    public Guid BotId { get; set; }

    public string BotNumber { get; set; } = null!;

    public Guid? BotLiftId { get; set; }

    public string? BotLiftName { get; set; }

    public Guid? LevelId { get; set; }

    public int? LevelNumber { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;
}
