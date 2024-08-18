using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwSkuWithActiveOutboundLpn
{
    public Guid OrderId { get; set; }

    public Guid OrderDetailId { get; set; }

    public Guid? SkuId { get; set; }
}
