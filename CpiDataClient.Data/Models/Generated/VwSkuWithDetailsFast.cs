using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwSkuWithDetailsFast
{
    public Guid Id { get; set; }

    public Guid SkuId { get; set; }

    public bool? IsInInventory { get; set; }

    public bool? HasAnyActiveInboundLpn { get; set; }

    public bool? HasAnyActiveOutboundLpn { get; set; }
}
