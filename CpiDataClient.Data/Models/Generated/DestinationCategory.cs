using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class DestinationCategory
{
    public Guid Id { get; set; }

    public bool CanAssignObjective { get; set; }

    public bool CanAssignOutbound { get; set; }

    public string? CustomerRef { get; set; }

    public string Name { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual ICollection<DestinationsDestinationCategory> DestinationsDestinationCategories { get; set; } = new List<DestinationsDestinationCategory>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
