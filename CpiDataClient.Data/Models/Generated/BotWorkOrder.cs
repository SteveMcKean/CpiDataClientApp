using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class BotWorkOrder
{
    public Guid Id { get; set; }

    public Guid BotId { get; set; }

    public virtual Bot Bot { get; set; } = null!;
}
