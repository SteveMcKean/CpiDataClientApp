using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class DestinationAvailabilityStatus
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<DestinationState> DestinationStates { get; set; } = new List<DestinationState>();
}
