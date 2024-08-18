using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OutboundBatch
{
    public Guid Id { get; set; }

    public virtual Outbound IdNavigation { get; set; } = null!;
}
