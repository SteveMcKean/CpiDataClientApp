using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class SegregationRuleSet
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public string SegregationZoneType { get; set; } = null!;
}
