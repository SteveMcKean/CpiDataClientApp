using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwSegregationZoneInfo
{
    public string? RuleSetDescription { get; set; }

    public int? RuleSetId { get; set; }

    public int? RuleTypeId { get; set; }

    public int? SegregationZoneTypeId { get; set; }

    public string ZoneRuleTypeName { get; set; } = null!;

    public int? PropertyId { get; set; }

    public string ExpectedValue { get; set; } = null!;

    public string RuleTypeName { get; set; } = null!;

    public int SegregationZoneId { get; set; }

    public Guid BayId { get; set; }

    public int SubTier { get; set; }

    public string ZoneDescription { get; set; } = null!;

    public bool EnforceChimney { get; set; }

    public string PropertyName { get; set; } = null!;

    public int ProductPropertyId { get; set; }

    public string ProductTypeName { get; set; } = null!;
}
