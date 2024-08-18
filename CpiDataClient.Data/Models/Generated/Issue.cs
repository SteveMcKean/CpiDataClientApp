using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Issue
{
    public Guid Id { get; set; }

    public string CreatedByUserName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool ToBeDeleted { get; set; }

    public int AssetType { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual AssetType AssetTypeNavigation { get; set; } = null!;

    public virtual ICollection<WorkOrderIssue> WorkOrderIssues { get; set; } = new List<WorkOrderIssue>();
}
