using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class SegregationZoneRuleSet
{
    public int Id { get; set; }

    public int SegregationZoneId { get; set; }

    public int RuleSetId { get; set; }
}
