using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class DestinationState
{
    public Guid Id { get; set; }

    public DateTimeOffset LastChangeTime { get; set; }

    public string LastChangeReason { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public int AvailabilityStatus { get; set; }

    public bool IsTest { get; set; }

    public virtual DestinationAvailabilityStatus AvailabilityStatusNavigation { get; set; } = null!;

    public virtual Destination IdNavigation { get; set; } = null!;
}
