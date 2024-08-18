using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwSegregationBayInfo
{
    public int SegregationZoneId { get; set; }

    public Guid BayId { get; set; }

    public int SubTier { get; set; }
}
