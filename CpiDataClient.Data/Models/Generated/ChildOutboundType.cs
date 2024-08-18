using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ChildOutboundType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Outbound> Outbounds { get; set; } = new List<Outbound>();
}
