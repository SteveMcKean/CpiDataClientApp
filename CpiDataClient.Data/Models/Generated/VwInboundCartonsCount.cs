using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwInboundCartonsCount
{
    public Guid Lpnid { get; set; }

    public Guid PalletId { get; set; }

    public int? CartonsStored { get; set; }

    public int? CartonsRejected { get; set; }

    public int? CartonsInducted { get; set; }
}
