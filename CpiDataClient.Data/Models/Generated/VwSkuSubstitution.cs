using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwSkuSubstitution
{
    public Guid SourceSkuId { get; set; }

    public string SourceSku { get; set; } = null!;

    public Guid SubstituteSkuId { get; set; }

    public string SubstituteSku { get; set; } = null!;

    public string? SourceSkuName { get; set; }

    public string? SubstituteSkuName { get; set; }
}
