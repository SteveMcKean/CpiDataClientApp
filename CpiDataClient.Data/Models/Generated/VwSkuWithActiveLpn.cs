using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwSkuWithActiveLpn
{
    public Guid LpnId { get; set; }

    public Guid InboundLpnId { get; set; }

    public int? LpnrejectReasonId { get; set; }

    public Guid? PalletLayerId { get; set; }

    public Guid SkuId { get; set; }
}
