using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OutboundParentChildMap
{
    public Guid ParentId { get; set; }

    public Guid ChildId { get; set; }

    public virtual Outbound Child { get; set; } = null!;

    public virtual Outbound Parent { get; set; } = null!;
}
