using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OutboundExtension
{
    public int Id { get; set; }

    public int ExtensionKeyId { get; set; }

    public int ExtensionValueId { get; set; }

    public Guid OutboundId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual OutboundExtensionKey ExtensionKey { get; set; } = null!;

    public virtual OutboundExtensionValue ExtensionValue { get; set; } = null!;

    public virtual Outbound Outbound { get; set; } = null!;
}
