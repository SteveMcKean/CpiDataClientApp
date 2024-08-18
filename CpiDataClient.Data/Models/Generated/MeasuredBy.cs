using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class MeasuredBy
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<InboundDimensionalVariant> InboundDimensionalVariants { get; set; } = new List<InboundDimensionalVariant>();

    public virtual ICollection<WarehousePack> WarehousePacks { get; set; } = new List<WarehousePack>();
}
