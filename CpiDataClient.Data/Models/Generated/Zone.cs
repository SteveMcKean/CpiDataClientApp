using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Zone
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public bool EnforceChimney { get; set; }

    public virtual ICollection<Sku> Skus { get; set; } = new List<Sku>();

    public virtual ICollection<ZoneBayModel> ZoneBayModels { get; set; } = new List<ZoneBayModel>();

    public virtual ICollection<ProductProperty> ProductProperties { get; set; } = new List<ProductProperty>();

    public virtual ICollection<RuleSet> RuleSets { get; set; } = new List<RuleSet>();
}
