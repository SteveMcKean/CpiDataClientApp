using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OperationalMode
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<OutboundPallet> OutboundPallets { get; set; } = new List<OutboundPallet>();
}
