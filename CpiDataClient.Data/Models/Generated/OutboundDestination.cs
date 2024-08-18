using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OutboundDestination
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<OutboundCarton> OutboundCartons { get; set; } = new List<OutboundCarton>();

    public virtual ICollection<Outbound> Outbounds { get; set; } = new List<Outbound>();
}
