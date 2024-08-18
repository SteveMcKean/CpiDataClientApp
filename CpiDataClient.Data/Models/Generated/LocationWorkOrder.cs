using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class LocationWorkOrder
{
    public Guid Id { get; set; }

    public Guid LocationId { get; set; }

    public virtual StructureLocation Location { get; set; } = null!;
}
