using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class SkuExtension
{
    public Guid Id { get; set; }

    public Guid SkuId { get; set; }

    public int ExtensionKeyId { get; set; }

    public string ExtensionValue { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual SkuExtensionKey ExtensionKey { get; set; } = null!;

    public virtual Sku Sku { get; set; } = null!;
}
