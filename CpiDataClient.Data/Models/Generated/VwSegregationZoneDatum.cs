using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwSegregationZoneDatum
{
    public int SegregationZoneId { get; set; }

    public string SegregationZone { get; set; } = null!;

    public string SegregationType { get; set; } = null!;
}
