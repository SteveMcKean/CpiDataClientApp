using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class LeadEdgeOrientation
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Carton> Cartons { get; set; } = new List<Carton>();

    public virtual ICollection<InboundDimensionalVariant> InboundDimensionalVariants { get; set; } = new List<InboundDimensionalVariant>();

    public virtual ICollection<Sku> Skus { get; set; } = new List<Sku>();
}
