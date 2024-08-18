using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OdvType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<OutboundDimensionalVariant> OutboundDimensionalVariants { get; set; } = new List<OutboundDimensionalVariant>();
}
