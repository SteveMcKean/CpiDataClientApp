using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwOrderOrderToteSummary
{
    public Guid OrderId { get; set; }

    public int? SupplyToteCount { get; set; }

    public int? OrderToteCount { get; set; }

    public int? TotalToteCount { get; set; }
}
