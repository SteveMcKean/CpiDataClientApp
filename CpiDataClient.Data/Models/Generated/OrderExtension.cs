using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OrderExtension
{
    public Guid Id { get; set; }

    /// <summary>
    /// FK Ref Orders.Orders.Id
    /// </summary>
    public Guid OrderId { get; set; }

    /// <summary>
    /// FK Ref Extension.OrderExtensionKey.Id.
    /// </summary>
    public int ExtensionKeyId { get; set; }

    public string ExtensionValue { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual OrderExtensionKey ExtensionKey { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
