using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class RuleType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<RuleModel> RuleModels { get; set; } = new List<RuleModel>();
}
