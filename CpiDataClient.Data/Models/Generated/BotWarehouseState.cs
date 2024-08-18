using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class BotWarehouseState
{
    public Guid Id { get; set; }

    public DateTimeOffset FromDate { get; set; }

    public DateTimeOffset? ToDate { get; set; }

    public int Location { get; set; }

    public Guid BotId { get; set; }

    public Guid? BotLiftId { get; set; }

    public Guid? LevelId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual Bot Bot { get; set; } = null!;

    public virtual Level1? Level { get; set; }

    public virtual BotLocation LocationNavigation { get; set; } = null!;
}
