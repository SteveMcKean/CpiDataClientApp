using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class SegregationRuleModel
{
    public int Id { get; set; }

    public int RuleSetId { get; set; }

    public string Type { get; set; } = null!;

    public string Property { get; set; } = null!;

    public string ExpectedValue { get; set; } = null!;
}
