using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class SkuExtensionsTemp
{
    public Guid Id { get; set; }

    public Guid SkuId { get; set; }

    public int ExtensionKeyId { get; set; }

    public string ExtensionValue { get; set; } = null!;

    public int? ReconTypeAction { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;
}
