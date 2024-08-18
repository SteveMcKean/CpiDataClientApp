using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class PackagingType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public bool IsActive { get; set; }

    public DateTimeOffset CreatedDate { get; set; }

    public DateTimeOffset ModifiedDate { get; set; }

    public int NestingDepth { get; set; }

    public bool? IsDefault { get; set; }

    public bool IsOpenTote { get; set; }

    public virtual ICollection<Sku> Skus { get; set; } = new List<Sku>();
}
