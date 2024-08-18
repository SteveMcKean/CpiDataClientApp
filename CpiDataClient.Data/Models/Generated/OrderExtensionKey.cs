using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OrderExtensionKey
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public DateTimeOffset CreatedDate { get; set; }

    public DateTimeOffset ModifiedDate { get; set; }

    public virtual ICollection<OrderExtension> OrderExtensions { get; set; } = new List<OrderExtension>();
}
