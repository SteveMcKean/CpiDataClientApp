using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Resolution
{
    public Guid Id { get; set; }

    public string CreatedByUserName { get; set; } = null!;

    public DateTimeOffset CreatedTime { get; set; }

    public string Description { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool ToBeDeleted { get; set; }

    public bool IsExclusive { get; set; }

    public int AssetType { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual AssetType AssetTypeNavigation { get; set; } = null!;
}
