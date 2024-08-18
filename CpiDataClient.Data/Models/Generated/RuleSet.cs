using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class RuleSet
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public int? SegregationZoneTypeId { get; set; }

    public virtual ICollection<RuleModel> RuleModels { get; set; } = new List<RuleModel>();

    public virtual ZoneType? SegregationZoneType { get; set; }

    public virtual ICollection<Zone> SegregationZones { get; set; } = new List<Zone>();
}
