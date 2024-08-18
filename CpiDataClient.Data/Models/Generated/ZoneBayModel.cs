using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ZoneBayModel
{
    public int Id { get; set; }

    public int SegregationZoneId { get; set; }

    public int SubTier { get; set; }

    public Guid BayId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public virtual Bay1 Bay { get; set; } = null!;

    public virtual Zone SegregationZone { get; set; } = null!;
}
