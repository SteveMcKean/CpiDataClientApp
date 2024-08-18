using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ZoneType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<RuleSet> RuleSets { get; set; } = new List<RuleSet>();
}
