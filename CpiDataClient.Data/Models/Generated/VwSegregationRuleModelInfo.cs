using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwSegregationRuleModelInfo
{
    public int RuleSetId { get; set; }

    public int Type { get; set; }

    public int PropertyId { get; set; }

    public string ExpectedValue { get; set; } = null!;
}
