using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Lpnextension
{
    public Guid Id { get; set; }

    /// <summary>
    /// FK Ref Sku.LPNs.ID
    /// </summary>
    public Guid Lpnid { get; set; }

    /// <summary>
    /// FK Ref Extension.LPNExtensionKey.Id.
    /// </summary>
    public int ExtensionKeyId { get; set; }

    public string ExtensionValue { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual LpnextensionKey ExtensionKey { get; set; } = null!;

    public virtual Lpn Lpn { get; set; } = null!;
}
