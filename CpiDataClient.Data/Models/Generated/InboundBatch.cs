using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class InboundBatch
{
    public Guid Id { get; set; }

    public virtual Inbound IdNavigation { get; set; } = null!;
}
