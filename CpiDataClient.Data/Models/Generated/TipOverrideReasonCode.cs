using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class TipOverrideReasonCode
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<InboundDimensionalVariant> InboundDimensionalVariants { get; set; } = new List<InboundDimensionalVariant>();
}
