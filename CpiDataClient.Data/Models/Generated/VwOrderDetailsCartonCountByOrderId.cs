using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwOrderDetailsCartonCountByOrderId
{
    public Guid OrderId { get; set; }

    public int? TotalCartons { get; set; }
}
