using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class DestinationStatesTombstone
{
    public int DestStatesTombstoneSk { get; set; }

    public Guid Id { get; set; }

    public Guid DestinationId { get; set; }

    public DateTimeOffset LastChangeTime { get; set; }

    public string LastChangeReason { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public int? AvailabilityStatus { get; set; }

    public bool IsTest { get; set; }

    public DateTime TombstoneDate { get; set; }
}
