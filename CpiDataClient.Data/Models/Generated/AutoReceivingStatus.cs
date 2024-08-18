using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class AutoReceivingStatus
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<InboundLpn> InboundLpns { get; set; } = new List<InboundLpn>();
}
