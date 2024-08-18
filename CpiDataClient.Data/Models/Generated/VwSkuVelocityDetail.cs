using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwSkuVelocityDetail
{
    public Guid Id { get; set; }

    public DateOnly? CriteriaDate { get; set; }

    public int? InboundLpnCount { get; set; }
}
