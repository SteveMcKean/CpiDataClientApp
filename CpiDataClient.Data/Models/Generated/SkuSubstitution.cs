using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class SkuSubstitution
{
    public Guid SourceSkuId { get; set; }

    public Guid SubstituteSkuId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual Sku SourceSku { get; set; } = null!;

    public virtual Sku SubstituteSku { get; set; } = null!;
}
