using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OrderDetailExtension
{
    public Guid Id { get; set; }

    /// <summary>
    /// FK Ref Orders.OrderDetails.ID
    /// </summary>
    public Guid OrderDetailId { get; set; }

    /// <summary>
    /// FK Ref Extension.OrderDetailExtensionKey.Id.
    /// </summary>
    public int ExtensionKeyId { get; set; }

    public string ExtensionValue { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual OrderDetailExtensionKey ExtensionKey { get; set; } = null!;

    public virtual OrderDetail OrderDetail { get; set; } = null!;
}
