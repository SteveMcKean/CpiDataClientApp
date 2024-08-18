using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class SegregationZoneProductType
{
    public int Id { get; set; }

    public int SegregationZoneId { get; set; }

    public string ProductType { get; set; } = null!;
}
