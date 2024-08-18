using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ProductProperty
{
    public int Id { get; set; }

    public string PropertyName { get; set; } = null!;

    public string ProductTypeName { get; set; } = null!;

    public virtual ICollection<RuleModel> RuleModels { get; set; } = new List<RuleModel>();

    public virtual ICollection<Zone> SegregationZones { get; set; } = new List<Zone>();
}
