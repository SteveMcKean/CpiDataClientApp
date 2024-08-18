using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class AssetType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Issue> Issues { get; set; } = new List<Issue>();

    public virtual ICollection<Resolution> Resolutions { get; set; } = new List<Resolution>();

    public virtual ICollection<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>();
}
