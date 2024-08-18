using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class InboundDestination
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<InboundCarton> InboundCartons { get; set; } = new List<InboundCarton>();
}
