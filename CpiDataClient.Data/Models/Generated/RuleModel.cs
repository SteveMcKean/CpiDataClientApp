using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class RuleModel
{
    public int Id { get; set; }

    public int? RuleSetId { get; set; }

    public int? RuleTypeId { get; set; }

    public int? PropertyId { get; set; }

    public string ExpectedValue { get; set; } = null!;

    public virtual ProductProperty? Property { get; set; }

    public virtual RuleSet? RuleSet { get; set; }

    public virtual RuleType? RuleType { get; set; }
}
