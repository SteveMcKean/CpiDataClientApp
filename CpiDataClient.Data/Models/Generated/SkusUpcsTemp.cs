using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class SkusUpcsTemp
{
    public Guid SkuId { get; set; }

    public Guid UpcId { get; set; }

    public int StateChange { get; set; }
}
